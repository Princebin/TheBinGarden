using Ay.MvcFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TomatoClock.Models;
using TomatoClock.Views.Alarm;

namespace TomatoClock.Controllers
{
    public class AlarmController : Controller
    {
        public AlarmController() : base()
        {
            Model = new AlarmModel();
            Model.Groupings.Add(new DropDownOption { Key = 0, Text = "全部分组" });
            Model.Groupings.Add(new DropDownOption { Key = 1, Text = "创建分组" });
            Model.GroupingItem = Model.Groupings.FirstOrDefault();
            AYUI.Message.Register<Models.Alarm>(this, "AddAlarm", AddAlarm);
            NewAlarm = inParam =>
            {
                NewAlarmMethod();
            };
        }

        private void AddAlarm(Models.Alarm obj)
        {

            Model.ObservableCollection.Add(obj);
        }

        private void NewAlarmMethod()
        {
            AlarmSeting alarmSeting = new AlarmSeting();
            alarmSeting.ShowDialog();
        }

        public AlarmModel Model { get; set; }
        public ActionResult NewAlarm { get; private set; }
    }
}
