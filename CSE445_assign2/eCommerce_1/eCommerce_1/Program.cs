using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace eCommerce_1
{

    public delegate void priceCutEvent(Int32 pr); //define a delegate for price cut
    public delegate void ConfrimationEvent(Order order); //define delegate for order confirm
    //----ChickenFarm------Editing--------------------------------------------
    public class ChickenFarm
    {
        public static int pEnd=0;    //price cut #
        static Random rng = new Random();// get random number
        public static event priceCutEvent priceCut; //link event to delegate
        public static event ConfrimationEvent confrim;//confrim for order
        private static Int32 chickenPrice = 10;      //init price
        public Int32 getPrice() { return chickenPrice; }
        //-----------PriceModel-----------
        public void farmerFunc()//change price
        {
            for (Int32 i = 0; i < 40; i++)
            {
                Thread.Sleep(500);
                Int32 p = rng.Next(5, 10);
                if (p < chickenPrice)
                {
                    if (++pEnd == 10) {
                        Console.WriteLine("10 price Cuts, ChickenFarm Shut Down!");
                        break; }
                    priceCut(p);    //call event
                }
                chickenPrice = p;
            }
        }
        //------------PriceModel------------
       //-------------receiveOrder---------
        public void receiveOrder()
        {
            MultiCellBuffer midcells = new MultiCellBuffer();
            string ordstring;
            Coder cod = new Coder();
            for (int i = 0; i < 80; i++)
            {
                Thread.Sleep(50);
                ordstring=midcells.getOneCell();
                if (ordstring != null)
                {  
                    Thread OrderProcessingThread = new Thread(new ParameterizedThreadStart(OrderProcessing));  
                    //create new thread for each order
                    OrderProcessing(ordstring);
                }                
            }      
        }
        //-----------------------
        private void OrderProcessing(object ordStrObj) {
            string ordstring = ordStrObj.ToString();
            Coder cod = new Coder();
            Order  ord = cod.Decoder(ordstring);
            int BuyCard = ord.getCardNo();
            Console.WriteLine("ChickenFarm received one order from store{0}", ord.getID());
            double taxRate = 0.09;
            double tot = (taxRate + 1) *ord.getPrice()* ord.getAmt();
            Console.WriteLine("Store{0} wants to buy {1} chickens in totally {2} dollars!", ord.getID(), ord.getAmt(), tot);
            if (BuyCard>=350 && BuyCard<=450) {   //check card # correct or not
                Program.confirmed = false;
                confrim(ord);    //call order confirm
            }
            else { Console.WriteLine("Store{0} failed to buy chickens cause of wrong Card #!",ord.getID()); }
        }  
    }

    //------Retailer----------------------------------------------------------
    public class Retailer{
        public static DateTime startTime;   //to track each order duration
        public static DateTime endTime;
        public int id;
        public void retailerFunc(object idd){ //for starting thread
            this.id = Convert.ToInt32(idd);

            ChickenFarm chicken = new ChickenFarm();
            for(Int32 i=0;i<10;i++){
                Thread.Sleep(1000);
                Int32 p =chicken.getPrice();
                Console.WriteLine("Store{0} has everyday low price: ${1} each", id, p);
            }
        }
        public void chickenOnSale(Int32 p){   //will sendOrder
            Console.WriteLine("chickens are on sale: as low as ${0} each",p);
            Console.WriteLine("Store{0} wants buy {1} chickens", id, (10 - p) * 10);  //(10-p)*p is amount
            Random rd = new Random();
            int card = rd.Next(300,500);     
            Order ord = new Order(id,card,(10-p)*10,p);   //init order
            startTime= DateTime.Now;   //track order
            sendOrder(ord);          
        }
        public void sendOrder(Order ord)
        {
            Coder cod = new Coder();
            MultiCellBuffer midcells = new MultiCellBuffer();
            Thread setorder = new Thread(new ParameterizedThreadStart(midcells.setOneCell));
            Console.WriteLine("Store{0} has sent one order", id);
            setorder.Start(cod.Encoder(ord));   //each order create a new thread
        }
        public void Confirmation(Order ord) {
            endTime = DateTime.Now;   //track end time
            if (Program.confirmed == false)
            {
                Console.WriteLine("Store{0} has bought {1} chickens sucessfully! spend{2} ", ord.getID(), ord.getAmt(), endTime - startTime);
                Program.confirmed = true;
            }
        }

    }
    //----------Retailer-------------------------------
    //---------MultiCellBuffer-----OK----------------
    public class MultiCellBuffer
    {
        public class cell    //internal class
        {
            public Boolean islock=false;
            public  string data=null;
 
        }
        public static  Semaphore sem = new Semaphore(3,3);  //mutex
        public static cell[] buffers = new cell[3];
        public void initCells(){   //to init cell
          for(int j=0;j<3;j++){
                    buffers[j]=new cell();
                }
        }
        public string getOneCell(){   //get order from buffer
            string str=null; 
            sem.WaitOne();
            for (int i = 0; i < 3; i++)
            {
                Thread.Sleep(100);
                if (!buffers[i].islock && buffers[i].data!=null)  //can get
                {
                    buffers[i].islock = true;
                    str = buffers[i].data;
                    buffers[i].data = null;           
                    buffers[i].islock = false;
                    sem.Release();
                    return str;
                }
            }
            return null;
        }
        public void setOneCell(object strObj){  // set cell to buffer
            string str = strObj.ToString();
            int i;
            sem.WaitOne();
            for (i = 0; i < 3; i++)
            {
                Thread.Sleep(100);
                if (!buffers[i].islock&& buffers[i].data==null)
                {
                    buffers[i].islock = true;
                    buffers[i].data=str;
                    buffers[i].islock = false;
                    break;
                }
            }
            sem.Release();
        }
    }
    //-----------MultiCellBuffer---------------------------
    //----Order------OK----------------------------------------------------------------
    public class Order
    {
        
        private int senderId; //retailer's name or id
        private int cardNo;   // credit card num
        private int amount;  // order amount
        private int price;// order price
        public Order() { }
        public Order(int id,int no,int amt,int pric){
        senderId=id;
        cardNo = no;
        amount = amt;
        price = pric;
    }


        Mutex myMutex = new Mutex();
        public int getPrice() { return this.price; }
        public void setPrice(int pric)
        {
            myMutex.WaitOne();  //monitor
            try
            {
                this.price = pric;
            }
            finally { myMutex.ReleaseMutex(); }
        }
        public int getID() { return this.senderId; }
        public void setID(int id)
        {
            myMutex.WaitOne();
            try
            {
                this.senderId = id;
            }
            finally { myMutex.ReleaseMutex(); }
        }
        public int getCardNo() { return this.cardNo; }
        public void setCardNo(int No) {
            myMutex.WaitOne();
            try
            {
                this.cardNo = No;
            }
            finally { myMutex.ReleaseMutex(); } 
    }
        public int getAmt() { return this.amount; }
        public void setAmt(int amt)
        {
            myMutex.WaitOne();
            try
            {
                this.amount = amt;
            }
            finally { myMutex.ReleaseMutex(); } 
        }
    }
    //--------------------------------------order--------------------------
    //------Coder-----OK---------------------------------------------------
    public class Coder{
        
        public string Encoder(Order order)
        {
            string  str = Convert.ToString(order.getID()) + "_" + Convert.ToString(order.getCardNo()) 
                + "_" + Convert.ToString(order.getAmt())+"_"+Convert.ToString(order.getPrice());
            webEncrypt.ServiceClient proxy = new webEncrypt.ServiceClient();//make sure your internet is connected
            return proxy.Encrypt(str);
          //  proxy.Close();
        }
        public Order Decoder(string orderstr)
        {
            Order ord = new Order();
            webEncrypt.ServiceClient proxy = new webEncrypt.ServiceClient();
            string str = proxy.Decrypt(orderstr);   
            string[] arr = str.Split(new char[] { '_' });   //from string to order
            ord.setID(Convert.ToInt32(arr[0]));
            ord.setCardNo(Convert.ToInt32(arr[1]));
            ord.setAmt(Convert.ToInt32(arr[2]));
            ord.setPrice(Convert.ToInt32(arr[3]));
            return ord;
        }
}
    //------Coder--------------------------------------------------------

    class Program
    {
        public static int items = 0;
        public static Boolean confirmed = false;  //avoid multi confirm
        static void Main(string[] args)
        {
         MultiCellBuffer midcells = new MultiCellBuffer();
         midcells.initCells();  //init buffer cells
            ChickenFarm chicken= new ChickenFarm();
            Thread farmer =new Thread(new ThreadStart(chicken.farmerFunc));  
            Thread receivOrd = new Thread(new ThreadStart(chicken.receiveOrder));
            farmer.Start();  //start one farmer thread
            receivOrd.Start();//start check order thread
            Retailer[] retailers =new Retailer[5];
                for (int i = 0; i < 5; i++)
                {           //N=5 here
                    retailers[i] = new Retailer();
                    Thread retail = new Thread(new ParameterizedThreadStart(retailers[i].retailerFunc));
                    ChickenFarm.priceCut += new priceCutEvent(retailers[i].chickenOnSale);   //cut event
                    ChickenFarm.confrim += new ConfrimationEvent(retailers[i].Confirmation);  // confirm event
                    retail.Start(i);
                }

                Console.ReadLine();
        }
    }
}
