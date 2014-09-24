using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码、服务和配置文件中的类名“Service”。
public class Service : IService
{
    public string GetData(int value)
    {
        return string.Format("You entered: {0}", value);
    }
    //TODO: Add your C# code here that implement the interface
    public double PiValue()
    {
        double pi = System.Math.PI;
        return (pi);
    }
    public int absValue(int x)
    {
        if (x >= 0) return (x);
        else return (-x);
    }
    public int c2f(int c)
    {
        return (c * 9 / 5 + 32);
    }
    public int f2c(int f)
    {
        return ((f - 32) * 5 / 9);
    }
}

