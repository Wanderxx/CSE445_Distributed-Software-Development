namespace part4
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.Gobtn = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.part5_De = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.part5_En = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.part5_btn = new System.Windows.Forms.Button();
            this.part5_txtinput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.part6_btn = new System.Windows.Forms.Button();
            this.part6_txtinput = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.Day5_highTmp = new System.Windows.Forms.TextBox();
            this.Day5_lowTmp = new System.Windows.Forms.TextBox();
            this.Day5_weather = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.Day4_highTmp = new System.Windows.Forms.TextBox();
            this.Day4_lowTmp = new System.Windows.Forms.TextBox();
            this.Day4_weather = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.Day3_highTmp = new System.Windows.Forms.TextBox();
            this.Day3_lowTmp = new System.Windows.Forms.TextBox();
            this.Day3_weather = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Day2_highTmp = new System.Windows.Forms.TextBox();
            this.Day2_lowTmp = new System.Windows.Forms.TextBox();
            this.Day2_weather = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Day1_highTmp = new System.Windows.Forms.TextBox();
            this.Day1_lowTmp = new System.Windows.Forms.TextBox();
            this.Day1_weather = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.part8_city = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.part8_btn = new System.Windows.Forms.Button();
            this.part8_input = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(29, 12);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(607, 22);
            this.txtUrl.TabIndex = 0;
            this.txtUrl.Text = "http://";
            // 
            // Gobtn
            // 
            this.Gobtn.Location = new System.Drawing.Point(661, 12);
            this.Gobtn.Name = "Gobtn";
            this.Gobtn.Size = new System.Drawing.Size(45, 22);
            this.Gobtn.TabIndex = 1;
            this.Gobtn.Text = "Go";
            this.Gobtn.UseVisualStyleBackColor = true;
            this.Gobtn.Click += new System.EventHandler(this.Gobtn_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(29, 40);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(935, 280);
            this.webBrowser1.TabIndex = 2;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.part5_De);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.part5_En);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.part5_btn);
            this.groupBox1.Controls.Add(this.part5_txtinput);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(29, 337);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 220);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "part5 Encryption";
            // 
            // part5_De
            // 
            this.part5_De.Location = new System.Drawing.Point(19, 177);
            this.part5_De.Name = "part5_De";
            this.part5_De.Size = new System.Drawing.Size(189, 22);
            this.part5_De.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "Decryption";
            // 
            // part5_En
            // 
            this.part5_En.Location = new System.Drawing.Point(19, 114);
            this.part5_En.Name = "part5_En";
            this.part5_En.Size = new System.Drawing.Size(189, 22);
            this.part5_En.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Encryption";
            // 
            // part5_btn
            // 
            this.part5_btn.Location = new System.Drawing.Point(230, 44);
            this.part5_btn.Name = "part5_btn";
            this.part5_btn.Size = new System.Drawing.Size(75, 23);
            this.part5_btn.TabIndex = 2;
            this.part5_btn.Text = "submit";
            this.part5_btn.UseVisualStyleBackColor = true;
            this.part5_btn.Click += new System.EventHandler(this.part5_btn_Click);
            // 
            // part5_txtinput
            // 
            this.part5_txtinput.Location = new System.Drawing.Point(19, 45);
            this.part5_txtinput.Name = "part5_txtinput";
            this.part5_txtinput.Size = new System.Drawing.Size(189, 22);
            this.part5_txtinput.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input what you want encrypt";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.priceBox);
            this.groupBox2.Controls.Add(this.part6_btn);
            this.groupBox2.Controls.Add(this.part6_txtinput);
            this.groupBox2.Location = new System.Drawing.Point(386, 337);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(431, 220);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Part6 stock Quote";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "Price";
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(96, 69);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(100, 22);
            this.priceBox.TabIndex = 4;
            // 
            // part6_btn
            // 
            this.part6_btn.Location = new System.Drawing.Point(123, 30);
            this.part6_btn.Name = "part6_btn";
            this.part6_btn.Size = new System.Drawing.Size(75, 23);
            this.part6_btn.TabIndex = 3;
            this.part6_btn.Text = "Invoke";
            this.part6_btn.UseVisualStyleBackColor = true;
            this.part6_btn.Click += new System.EventHandler(this.part6_btn_Click);
            // 
            // part6_txtinput
            // 
            this.part6_txtinput.Location = new System.Drawing.Point(17, 29);
            this.part6_txtinput.Name = "part6_txtinput";
            this.part6_txtinput.Size = new System.Drawing.Size(100, 22);
            this.part6_txtinput.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox8);
            this.groupBox3.Controls.Add(this.groupBox7);
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.part8_city);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.part8_btn);
            this.groupBox3.Controls.Add(this.part8_input);
            this.groupBox3.Location = new System.Drawing.Point(29, 563);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(935, 207);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Part8 weather";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.Day5_highTmp);
            this.groupBox8.Controls.Add(this.Day5_lowTmp);
            this.groupBox8.Controls.Add(this.Day5_weather);
            this.groupBox8.Controls.Add(this.label18);
            this.groupBox8.Controls.Add(this.label19);
            this.groupBox8.Controls.Add(this.label20);
            this.groupBox8.Location = new System.Drawing.Point(726, 61);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(170, 130);
            this.groupBox8.TabIndex = 13;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Day5";
            // 
            // Day5_highTmp
            // 
            this.Day5_highTmp.Location = new System.Drawing.Point(59, 82);
            this.Day5_highTmp.Name = "Day5_highTmp";
            this.Day5_highTmp.Size = new System.Drawing.Size(100, 22);
            this.Day5_highTmp.TabIndex = 14;
            // 
            // Day5_lowTmp
            // 
            this.Day5_lowTmp.Location = new System.Drawing.Point(59, 56);
            this.Day5_lowTmp.Name = "Day5_lowTmp";
            this.Day5_lowTmp.Size = new System.Drawing.Size(100, 22);
            this.Day5_lowTmp.TabIndex = 13;
            // 
            // Day5_weather
            // 
            this.Day5_weather.Location = new System.Drawing.Point(59, 27);
            this.Day5_weather.Name = "Day5_weather";
            this.Day5_weather.Size = new System.Drawing.Size(100, 22);
            this.Day5_weather.TabIndex = 10;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(12, 92);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(48, 12);
            this.label18.TabIndex = 12;
            this.label18.Text = "highTmp";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(12, 59);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(44, 12);
            this.label19.TabIndex = 11;
            this.label19.Text = "lowTmp";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(12, 30);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(41, 12);
            this.label20.TabIndex = 10;
            this.label20.Text = "weather";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.Day4_highTmp);
            this.groupBox7.Controls.Add(this.Day4_lowTmp);
            this.groupBox7.Controls.Add(this.Day4_weather);
            this.groupBox7.Controls.Add(this.label15);
            this.groupBox7.Controls.Add(this.label16);
            this.groupBox7.Controls.Add(this.label17);
            this.groupBox7.Location = new System.Drawing.Point(550, 61);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(170, 130);
            this.groupBox7.TabIndex = 12;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Day4";
            // 
            // Day4_highTmp
            // 
            this.Day4_highTmp.Location = new System.Drawing.Point(59, 82);
            this.Day4_highTmp.Name = "Day4_highTmp";
            this.Day4_highTmp.Size = new System.Drawing.Size(100, 22);
            this.Day4_highTmp.TabIndex = 14;
            // 
            // Day4_lowTmp
            // 
            this.Day4_lowTmp.Location = new System.Drawing.Point(59, 56);
            this.Day4_lowTmp.Name = "Day4_lowTmp";
            this.Day4_lowTmp.Size = new System.Drawing.Size(100, 22);
            this.Day4_lowTmp.TabIndex = 13;
            // 
            // Day4_weather
            // 
            this.Day4_weather.Location = new System.Drawing.Point(59, 27);
            this.Day4_weather.Name = "Day4_weather";
            this.Day4_weather.Size = new System.Drawing.Size(100, 22);
            this.Day4_weather.TabIndex = 10;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 92);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 12);
            this.label15.TabIndex = 12;
            this.label15.Text = "highTmp";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 59);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 12);
            this.label16.TabIndex = 11;
            this.label16.Text = "lowTmp";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 30);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 12);
            this.label17.TabIndex = 10;
            this.label17.Text = "weather";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.Day3_highTmp);
            this.groupBox6.Controls.Add(this.Day3_lowTmp);
            this.groupBox6.Controls.Add(this.Day3_weather);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Location = new System.Drawing.Point(374, 61);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(170, 130);
            this.groupBox6.TabIndex = 11;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Day3";
            // 
            // Day3_highTmp
            // 
            this.Day3_highTmp.Location = new System.Drawing.Point(59, 82);
            this.Day3_highTmp.Name = "Day3_highTmp";
            this.Day3_highTmp.Size = new System.Drawing.Size(100, 22);
            this.Day3_highTmp.TabIndex = 14;
            // 
            // Day3_lowTmp
            // 
            this.Day3_lowTmp.Location = new System.Drawing.Point(59, 56);
            this.Day3_lowTmp.Name = "Day3_lowTmp";
            this.Day3_lowTmp.Size = new System.Drawing.Size(100, 22);
            this.Day3_lowTmp.TabIndex = 13;
            // 
            // Day3_weather
            // 
            this.Day3_weather.Location = new System.Drawing.Point(59, 27);
            this.Day3_weather.Name = "Day3_weather";
            this.Day3_weather.Size = new System.Drawing.Size(100, 22);
            this.Day3_weather.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 92);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 12);
            this.label12.TabIndex = 12;
            this.label12.Text = "highTmp";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 59);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 12);
            this.label13.TabIndex = 11;
            this.label13.Text = "lowTmp";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 30);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 12);
            this.label14.TabIndex = 10;
            this.label14.Text = "weather";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Day2_highTmp);
            this.groupBox5.Controls.Add(this.Day2_lowTmp);
            this.groupBox5.Controls.Add(this.Day2_weather);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Location = new System.Drawing.Point(205, 61);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(170, 130);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Day2";
            // 
            // Day2_highTmp
            // 
            this.Day2_highTmp.Location = new System.Drawing.Point(59, 82);
            this.Day2_highTmp.Name = "Day2_highTmp";
            this.Day2_highTmp.Size = new System.Drawing.Size(100, 22);
            this.Day2_highTmp.TabIndex = 14;
            // 
            // Day2_lowTmp
            // 
            this.Day2_lowTmp.Location = new System.Drawing.Point(59, 56);
            this.Day2_lowTmp.Name = "Day2_lowTmp";
            this.Day2_lowTmp.Size = new System.Drawing.Size(100, 22);
            this.Day2_lowTmp.TabIndex = 13;
            // 
            // Day2_weather
            // 
            this.Day2_weather.Location = new System.Drawing.Point(59, 27);
            this.Day2_weather.Name = "Day2_weather";
            this.Day2_weather.Size = new System.Drawing.Size(100, 22);
            this.Day2_weather.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 12);
            this.label9.TabIndex = 12;
            this.label9.Text = "highTmp";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 12);
            this.label10.TabIndex = 11;
            this.label10.Text = "lowTmp";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 10;
            this.label11.Text = "weather";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Day1_highTmp);
            this.groupBox4.Controls.Add(this.Day1_lowTmp);
            this.groupBox4.Controls.Add(this.Day1_weather);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(29, 61);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(170, 130);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Day1";
            // 
            // Day1_highTmp
            // 
            this.Day1_highTmp.Location = new System.Drawing.Point(59, 82);
            this.Day1_highTmp.Name = "Day1_highTmp";
            this.Day1_highTmp.Size = new System.Drawing.Size(100, 22);
            this.Day1_highTmp.TabIndex = 14;
            // 
            // Day1_lowTmp
            // 
            this.Day1_lowTmp.Location = new System.Drawing.Point(59, 56);
            this.Day1_lowTmp.Name = "Day1_lowTmp";
            this.Day1_lowTmp.Size = new System.Drawing.Size(100, 22);
            this.Day1_lowTmp.TabIndex = 13;
            // 
            // Day1_weather
            // 
            this.Day1_weather.Location = new System.Drawing.Point(59, 27);
            this.Day1_weather.Name = "Day1_weather";
            this.Day1_weather.Size = new System.Drawing.Size(100, 22);
            this.Day1_weather.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 12);
            this.label8.TabIndex = 12;
            this.label8.Text = "highTmp";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 12);
            this.label7.TabIndex = 11;
            this.label7.Text = "lowTmp";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "weather";
            // 
            // part8_city
            // 
            this.part8_city.AutoSize = true;
            this.part8_city.Location = new System.Drawing.Point(308, 24);
            this.part8_city.Name = "part8_city";
            this.part8_city.Size = new System.Drawing.Size(53, 12);
            this.part8_city.TabIndex = 8;
            this.part8_city.Text = "City, State";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "Zip code";
            // 
            // part8_btn
            // 
            this.part8_btn.Location = new System.Drawing.Point(192, 19);
            this.part8_btn.Name = "part8_btn";
            this.part8_btn.Size = new System.Drawing.Size(75, 23);
            this.part8_btn.TabIndex = 6;
            this.part8_btn.Text = "Submit";
            this.part8_btn.UseVisualStyleBackColor = true;
            this.part8_btn.Click += new System.EventHandler(this.part8_btn_Click);
            // 
            // part8_input
            // 
            this.part8_input.Location = new System.Drawing.Point(69, 19);
            this.part8_input.Name = "part8_input";
            this.part8_input.Size = new System.Drawing.Size(100, 22);
            this.part8_input.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 782);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.Gobtn);
            this.Controls.Add(this.txtUrl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Button Gobtn;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox part5_De;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox part5_En;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button part5_btn;
        private System.Windows.Forms.TextBox part5_txtinput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.Button part6_btn;
        private System.Windows.Forms.TextBox part6_txtinput;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button part8_btn;
        private System.Windows.Forms.TextBox part8_input;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox Day5_highTmp;
        private System.Windows.Forms.TextBox Day5_lowTmp;
        private System.Windows.Forms.TextBox Day5_weather;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox Day4_highTmp;
        private System.Windows.Forms.TextBox Day4_lowTmp;
        private System.Windows.Forms.TextBox Day4_weather;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox Day3_highTmp;
        private System.Windows.Forms.TextBox Day3_lowTmp;
        private System.Windows.Forms.TextBox Day3_weather;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox Day2_highTmp;
        private System.Windows.Forms.TextBox Day2_lowTmp;
        private System.Windows.Forms.TextBox Day2_weather;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox Day1_highTmp;
        private System.Windows.Forms.TextBox Day1_lowTmp;
        private System.Windows.Forms.TextBox Day1_weather;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label part8_city;
    }
}

