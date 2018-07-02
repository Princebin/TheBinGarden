using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern
{
     public class Chief
    {
        private string _name;
        MakeCoffee MakeLatteCoffee;

        public Chief(string name)
        {
            _name = name;
        }
        public void MakeCoffee()
        {
            MakeLatteCoffee = new Latte("意大利咖啡豆", "500度", "拿铁");
            MakeLatteCoffee.TemplateMethod();
            Coffee LatteCoffee = MakeLatteCoffee.GetResult();
            LatteCoffee.Show();
        }
    }
}
