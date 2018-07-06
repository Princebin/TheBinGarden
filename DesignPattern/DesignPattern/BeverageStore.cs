using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern
{
    /// <summary>
    /// 外观模式
    /// </summary>
    public class BeverageStore
    {
        Proxy proxy;

        public BeverageStore()
        {
            proxy = new Proxy();
            proxy.Day = "Sunday";
            proxy.Display();
        }
        
        public void Sell()
        {  
            proxy.Sell("拿铁");
        }
    }
}
