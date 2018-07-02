using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 模板方法模式
/// </summary>
namespace DesignPattern
{
    public abstract class MakeCoffee
    {
        private string _beanName;
        private string _temperature;
        public string _coffeeName;

        public MakeCoffee(string beanName, string temperature,string coffeeName)
        {
            _beanName = beanName;
            _temperature = temperature;
            _coffeeName = coffeeName;
        }

        public abstract void GrindBean(string BeanName);
        public abstract void Steaming(string Temperature);
        public void TemplateMethod()
        {
            Console.WriteLine("温杯");
            GrindBean(_beanName);
            Console.WriteLine("温壶");
            Steaming(_temperature);
            Console.WriteLine("冲泡");
            Console.WriteLine(_coffeeName + "泡好了！");
        }
        public abstract Coffee GetResult();
    }
    public class Latte : MakeCoffee
    {
        private Coffee coffee;
        public Latte(string beanName, string temperature,string coffeeName) : base(beanName, temperature, coffeeName)
        {
            coffee = new Coffee(coffeeName);
        }

        public override Coffee GetResult()
        {
            return coffee;
        }

        public override void GrindBean(string BeanName)
        {
            coffee.AddMaterial(BeanName);
            Console.WriteLine("研磨" + BeanName);
        }

        public override void Steaming(string Temperature)
        {
            coffee.SetTemperature(Temperature);
            Console.WriteLine("闷烧" + Temperature);
        }
    }
    public class Lanshan : MakeCoffee
    {
        private Coffee coffee;
        public Lanshan(string beanName, string temperature,string coffeeName) : base(beanName, temperature, coffeeName)
        {
            coffee = new Coffee(coffeeName);
        }

        public override Coffee GetResult()
        {
            return coffee;
        }

        public override void GrindBean(string BeanName)
        {
            coffee.AddMaterial(BeanName);
        }

        public override void Steaming(string Temperature)
        {
            coffee.SetTemperature(Temperature);
        }
    }
}
