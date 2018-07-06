using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.State
{
    public class SundayState : State
    {
        public override void Display(Proxy proxy)
        {
            if (string.Equals(proxy.Day, "Sunday"))
            {
                Console.WriteLine("员工称呼Sun");
            }
            else
            {
                proxy.SetState(new MondayState());
                proxy.Display();
            }
        }
    }
    public class MondayState : State
    {
        public override void Display(Proxy proxy)
        {
            if (string.Equals(proxy.Day, "Monday"))
            {
                Console.WriteLine("员工称呼Mon");
            }
            else
            {
                proxy.SetState(new TuesdayState());
                proxy.Display();
            }
        }
    }
    public class TuesdayState : State
    {
        public override void Display(Proxy proxy)
        {
            if (string.Equals(proxy.Day, "Tuesday"))
            {
                Console.WriteLine("员工称呼Tue");
            }
            else
            {
                proxy.SetState(new SundayState());
                proxy.Display();
            }
        }
    }
}
