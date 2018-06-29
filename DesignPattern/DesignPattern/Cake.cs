using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public class Cake:ICloneable
    {
        string Name { get; set; }
        Flur flur;

        public Cake(string name)
        {
            Name = name;
            flur = new Flur();
        }

        public Cake(Flur flur)
        {
            this.flur = (Flur)flur.Clone();
        }

        public void SetFlur(string growDate,string name)
        {
            flur.GrowDate = growDate;
            flur.Name = name;
        }
        public void Display()
        {
            Console.WriteLine("Cake'Name:" + Name);
            Console.WriteLine("Flur'Name:" + flur.Name);
            Console.WriteLine("Flur'GrowDate:" + flur.GrowDate);

        }

        public object Clone()
        {
            Cake obj = new Cake(this.flur);
            obj.Name = this.Name;
            return obj;
        }
    }
    public class Flur : ICloneable
    {
        public string GrowDate { get; set; }
        public string Name { get; set; }

        public object Clone()
        {
            return (object)this.MemberwiseClone();
        }
    }
}
