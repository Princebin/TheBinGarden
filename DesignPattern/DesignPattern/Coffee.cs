using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern
{
    /// <summary>
    ///建造者模式。
    /// </summary>
    public class Coffee
    {
        private string _name;
        private string _material;
        private string _temperature;

        public Coffee(string name)
        {
            _name = name;
        }
        public void AddMaterial(string material)
        {
            _material = material;
        }
        public void SetTemperature(string temperature)
        {
            _temperature = temperature;
        }
        public void Show()
        {
            Console.WriteLine(_name + "好了");
        }
    }
}
