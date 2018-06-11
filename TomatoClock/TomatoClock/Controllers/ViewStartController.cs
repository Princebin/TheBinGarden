using System;
using System.Collections.ObjectModel;
using Ay.Framework.WPF.Controls;
using Ay.MvcFramework;
using TomatoClock.Models;

namespace TomatoClock.Controllers
{
    public class ViewStartController : Controller
    {
        public ViewStartModel Model { get; set; }

        public ViewStartController() : base()
        {
            Model = new ViewStartModel();

        }


    }

}
