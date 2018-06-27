using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shejimos
{
    /// <summary>
    /// 代理模式解决了不能直接操作真实对象的问题，其中的动态代理更是使代理模式的使用简化不少。若使用静态代理，那么当有不用的真实对象（分别实现了不同的操作接口），我们只能去为被代理的真实对象重新生成一个代理类，而动态代理就解决了这一问题，用一个代理类，解决了所有真实对象的代理。
    /// 优点： 1、职责清晰。 2、高扩展性。 3、智能化。
//缺点： 1、由于在客户端和真实主题之间增加了代理对象，因此有些类型的代理模式可能会造成请求的处理速度变慢。 2、实现代理模式需要额外的工作，有些代理模式的实现非常复杂。
    /// </summary>
    abstract class Salesman
    {
        public abstract void Sell();
    }
    class Boss : Salesman
    {
        public override void Sell()
        {
            Drink drink = new Coffee();
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
        }
    }
    class Proxy : Salesman
    {
        Boss boss;

        public override void Sell()
        {
            if (boss == null)
            {
                boss = new Boss();
            }
            boss.Sell();
        }
    }
}
