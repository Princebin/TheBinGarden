using System;
using Ay.MvcFramework;
using TomatoClock.Views;

namespace TomatoClock
{
    public class Startup
    {
        [STAThread]
        static void Main()
        {

            new AYUIApplication<_ViewStart>(new Global(), true).Run();

        }

    }
}
