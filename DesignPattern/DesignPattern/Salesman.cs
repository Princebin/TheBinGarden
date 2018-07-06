using DesignPattern.State;
using System;

namespace DesignPattern
{
    /// <summary>
    /// 代理模式解决了不能直接操作真实对象的问题，其中的动态代理更是使代理模式的使用简化不少。若使用静态代理，那么当有不用的真实对象（分别实现了不同的操作接口），我们只能去为被代理的真实对象重新生成一个代理类，而动态代理就解决了这一问题，用一个代理类，解决了所有真实对象的代理。
    /// 优点： 1、职责清晰。 2、高扩展性。 3、智能化。
//缺点： 1、由于在客户端和真实主题之间增加了代理对象，因此有些类型的代理模式可能会造成请求的处理速度变慢。 2、实现代理模式需要额外的工作，有些代理模式的实现非常复杂。
    /// </summary>
    interface Subject
    {
        void Notify();
        string SubjectSate { get; set; }
    }
    public abstract class Salesman
    {
        public abstract void Sell(string coffeeName);
    }
    delegate void EventHandler();
    class Boss : Salesman,Subject
    {
        public event EventHandler Update;
        private string _action;
        public string SubjectSate
        {
            get { return _action; }
            set { _action = value; }
        }

        public void Notify()
        {
            Update();
        }

        public override void Sell(string coffeeName)
        {
            //MakeCoffee latte = new Latte("意大利咖啡豆", "500度");
            //latte.TemplateMethod();
            Drink drink = new CoffeePrice(coffeeName);
            Console.WriteLine(drink.GetDescription() + ":" + drink.Cost());
            drink = new Milk(drink);
            Console.WriteLine(drink.GetDescription() + ":" + drink.Cost());
            drink = new Sugar(drink);
            Console.WriteLine(drink.GetDescription() + ":" + drink.Cost());
            drink = new Sugar(drink);
            Console.WriteLine(drink.GetDescription() + ":" + drink.Cost());
            Cake cake = new Cake("草莓蛋糕");
            cake.SetFlur("1992-1995", "燕麦");
            cake.Display();
            //MakeCoffee lanshan = new Lanshan("牙买加蓝山咖啡豆", "600");
            //Drink lanshandrink = new CoffeePrice();
            //lanshan.TemplateMethod();
            //Console.WriteLine(lanshandrink.GetDescription() + ":" + lanshandrink.Cost());
        }
    }
    public class Proxy : Salesman
    {
        Boss boss;
        Chief chief;
        string day;
        State.State current;
        string person;

       public Proxy()
        {
            current = new SundayState();
        }

        public string Day { get => day; set => day = value; }

        public override void Sell(string coffeeName)
        {
            if (boss == null)
            {
                boss = new Boss();
                chief = new Chief("厨师");
                boss.Update += new EventHandler(chief.MakeCoffee);
                boss.SubjectSate = "做拿铁咖啡";
                boss.Notify();
            }
            boss.Sell(coffeeName);
        }
        public void SetState(State.State s)
        {
            current = s;
        }
        public void Display()
        {
           current.Display(this);
        }
    }
}
