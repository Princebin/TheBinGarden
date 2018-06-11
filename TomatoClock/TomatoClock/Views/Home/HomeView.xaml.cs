using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Ay.MvcFramework;
using Ay.MvcFramework.AyMarkupExtension;
using TomatoClock.Controllers;

namespace TomatoClock.Views.Home
{
    /// <summary>
    /// ResTestView.xaml 的交互逻辑
    /// </summary>
    public partial class HomeView : AyPage
    {
        public HomeView()
        {
            InitializeComponent();
            if (Checker1.IsChecked == true)
            {
                Mvc.Controller.Model.On_off = "开";
            }
            else
            {
                Mvc.Controller.Model.On_off = "关";
            }
            AYUI.Message.Register<string>(this, "IsEnble", SwicthEnble);
        }

        private void SwicthEnble(string obj)
        {
            if(Checker1.IsChecked == true)
            {
                Tomatotime.IsEnabled = false;
                Resttime.IsEnabled = false;
            }
            else
            {
                Tomatotime.IsEnabled = true;
                Resttime.IsEnabled = true;
            }
        }
    }
































    public partial class HomeView : AyPage
    {
        #region 控制器
        private Actions<HomeController> _mvc;
        public Actions<HomeController> Mvc
        {
            get
            {
                if (_mvc == null)
                {
                    _mvc = new Actions<HomeController>(DataContext as HomeController);
                }
                return _mvc;
            }
        }
        #endregion
    }
}
