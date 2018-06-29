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

        public MakeCoffee(string beanName, string temperature)
        {
            _beanName = beanName;
            _temperature = temperature;
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
            Console.WriteLine("咖啡泡好了！");
        }
    }
    public class Latte : MakeCoffee
    {
        public Latte(string beanName, string temperature) : base(beanName, temperature)
        {
        }

        public override void GrindBean(string BeanName)
        {
            Console.WriteLine(BeanName);
        }

        public override void Steaming(string Temperature)
        {
            Console.WriteLine("温度" + Temperature);
        }
    }
    public class Lanshan : MakeCoffee
    {
        public Lanshan(string beanName, string temperature) : base(beanName, temperature)
        {
        }

        public override void GrindBean(string BeanName)
        {
            Console.WriteLine(BeanName);
        }

        public override void Steaming(string Temperature)
        {
            Console.WriteLine("温度" + Temperature);
        }
    }
}
