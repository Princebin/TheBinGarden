using System;

namespace DesignPattern
{
    /// <summary>
    /// 适用场景：
    //扩展一个类的功能。
    //动态增加功能，动态撤销。

    //优点：
    //装饰类和被装饰类可以独立发展，不会相互耦合
    //动态的将责任附加到对象身上。
    //缺点：
    //多层装饰比较复杂。
    /// </summary>
    public class Drink
    {
        public virtual float Cost()
        {
            return 0;
        }
        public virtual String GetDescription()
        {
            return null;
        }
    }
    public class Coffee : Drink
    {
        public override float Cost()
        {
            return 10;
        }
        public override String GetDescription()
        {
            return "coffee";
        }
    }
    public class CondimentDecorator : Drink
    {
        protected Drink decoratorDrink;

        public CondimentDecorator(Drink decoratorDrink)
        {
            this.decoratorDrink = decoratorDrink;
        }
        public override float Cost()
        {
            return decoratorDrink.Cost();
        }
        public override String GetDescription()
        {
            return decoratorDrink.GetDescription();
        }
    }
    public class Milk : CondimentDecorator
    {
        public Milk(Drink decoratorDrink) : base(decoratorDrink)
        {
        }
        public override float Cost()
        {
            return base.Cost() + 2;
        }
        public override string GetDescription()
        {
            return base.GetDescription() + " milk";
        }
    }
    public class Sugar : CondimentDecorator
    {
        public Sugar(Drink decoratorDrink) : base(decoratorDrink)
        {
        }
        public override float Cost()
        {
            return base.Cost() + 1;
        }
        public override string GetDescription()
        {
            return base.GetDescription() + " sugar";
        }
    }
}
