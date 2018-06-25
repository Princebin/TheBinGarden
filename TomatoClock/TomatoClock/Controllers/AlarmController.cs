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
            Model.Groupings.Add(new Grouping { Key = 0, Text = "全部分组" });
            Model.Groupings.Add(new Grouping { Key = 1, Text = "创建分组" });
            Model.GroupingItem = Model.Groupings.FirstOrDefault();
            NewAlarm = inParam =>
            {
                NewAlarmMethod();
            };
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
