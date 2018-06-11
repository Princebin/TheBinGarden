using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Threading;
using Ay.MvcFramework;
using TomatoClock.Models;

namespace TomatoClock.Controllers
{
    public class HomeController : Controller
    {
        public HomeModel Model { get; set; }
        DispatcherTimer dispatcherTimer;
        public HomeController() : base()
        {
            Model = new HomeModel();
            Model.On_off = "关";
            Model.TomatoTime = 25;
            Model.RestTime = 5;
            Model.AlertTime = DateTime.Now.AddMinutes(Model.TomatoTime).ToString("HH:mm:ss");
            dispatcherTimer = new DispatcherTimer();
            StartTomato = inParam =>
             {
                 if (string.Equals(Model.On_off, "关"))
                 {

                     AYUI.Message.Send<string>(null, "IsEnble");
                     Model.On_off = "开";
                     TomatoStartTimer();
                 }
                 else
                 {
                     StopTimer();
                     AYUI.Message.Send<string>(null, "IsEnble");
                     Model.On_off = "关";
                 }
             };
            ReshTime = inParam =>
            {
                StopTimer();
                TomatoStartTimer();
            };
            OpenMusic = inParam =>
            {
                OpenMusicBtn();
            };
        }



        public ActionResult StartTomato { get; private set; }
        public ActionResult ReshTime { get; private set; }
        public ActionResult OpenMusic { get; private set; }
        private void TomatoStartTimer()
        {
            dispatcherTimer.Tick += new EventHandler(RemindingRest);
            dispatcherTimer.Interval = TimeSpan.FromMinutes(Model.TomatoTime);
            dispatcherTimer.Start();
            Model.AlertTime = DateTime.Now.AddMinutes(Model.TomatoTime).ToString("HH:mm:ss");
        }

        private void RemindingRest(object sender, EventArgs e)
        {
            if (System.Windows.Forms.MessageBox.Show("完成了一个番茄时间，休息一下吧", "Confirm Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                StopTimer();
                RestStatrTimer();
            }
        }

        private void RestStatrTimer()
        {
            dispatcherTimer.Tick += new EventHandler(RemindingTomato);
            dispatcherTimer.Interval = TimeSpan.FromMinutes(Model.RestTime);
            dispatcherTimer.Start();
            Model.AlertTime = DateTime.Now.AddMinutes(Model.RestTime).ToString("HH:mm:ss");
        }

        private void RemindingTomato(object sender, EventArgs e)
        {
            if (System.Windows.Forms.MessageBox.Show("休息好了，继续加油吧", "Confirm Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                TomatoStartTimer();
            }
            StopTimer();
        }

        private void StopTimer()
        {
            if (dispatcherTimer != null && dispatcherTimer.IsEnabled == true)
            {
                dispatcherTimer.Stop();
            }
        }
        private void OpenMusicBtn()
        {
           
        }
    }
}
