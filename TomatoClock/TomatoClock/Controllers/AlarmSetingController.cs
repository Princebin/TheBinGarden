using Ay.MvcFramework;
using System;
using TomatoClock.Models;

namespace TomatoClock.Controllers
{
    public class AlarmSetingController : Controller
    {
        public AlarmSetingModel Model { get; set; }
        private string RoundrobinModel { get; set; }
        public AlarmSetingController()
        {
            Model = new AlarmSetingModel();
            RoundrobinModel = "一次";
            Roundrobin = inParam =>
             {
                 ChooseRoundrobin(inParam.ToObjectString());
             };
            ApplicationAction = inParam =>
            {
                Application();
            };
        }

        private void Application()
        {
            Models.Alarm alarm = new Alarm();
            alarm.Frequency = RoundrobinModel;
            alarm.Date = string.Empty;
            alarm.Swich = true;
            alarm.IsShow = true;
            alarm.Surplus = "已过期";
            int tempint = 0;
            DateTime dateTime;
            TimeSpan timeSpan;
            switch (RoundrobinModel)
            {
                case "一次":
                    alarm.Date = Model.YearSet + "-" + Model.MonthSet + "-" + Model.DaySet;
                    if (Model.YearSet - DateTime.Now.Year > 0)
                    {
                        alarm.Surplus = (Model.YearSet - DateTime.Now.Year).ToString() + "年";
                    }
                    else if (Model.MonthSet - DateTime.Now.Month > 0)
                    {
                        alarm.Surplus = (Model.MonthSet - DateTime.Now.Month).ToString() + "月";
                    }
                    else if (Model.DaySet - DateTime.Now.Day > 0)
                    {
                        alarm.Surplus = (Model.DaySet - DateTime.Now.Day).ToString() + "天";
                    }
                    else if (Model.HourWarn - DateTime.Now.Hour > 0)
                    {
                        alarm.Surplus = (Model.HourWarn - DateTime.Now.Hour).ToString() + "时";
                    }
                    else if (Model.MinuteWarn - DateTime.Now.Minute > 0)
                    {
                        alarm.Surplus = (Model.MinuteWarn - DateTime.Now.Minute).ToString() + "分";
                    }
                    else if (Model.SecWarn - DateTime.Now.Second > 0)
                    {
                        alarm.Surplus = (Model.SecWarn - DateTime.Now.Second).ToString() + "秒";
                    }
                    else
                    {
                        alarm.Swich = false;
                    }
                    break;
                case "每天":
                    alarm.Date = "每天";
                    if (Model.HourWarn - DateTime.Now.Hour > 0)
                    {
                        alarm.Surplus = (Model.HourWarn - DateTime.Now.Hour).ToString() + "时";
                    }
                    else if (Model.MinuteWarn - DateTime.Now.Minute > 0)
                    {
                        alarm.Surplus = (Model.MinuteWarn - DateTime.Now.Minute).ToString() + "分";
                    }
                    else if (Model.SecWarn - DateTime.Now.Second > 0)
                    {
                        alarm.Surplus = (Model.SecWarn - DateTime.Now.Second).ToString() + "秒";
                    }
                    else
                    {
                        alarm.IsShow = false;
                    }
                    break;
                case "每周":
                    tempint =(int)DateTime.Now.DayOfWeek;
                    dateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, Model.HourWarn, Model.MinuteWarn, Model.MinuteWarn);
                    timeSpan = dateTime - DateTime.Now;
                    if (Model.Sunday)
                        alarm.Date += "周日";
                    if (Model.Monday)
                        alarm.Date += "周一";
                    if (Model.Tuesday)
                        alarm.Date += "周二";
                    if (Model.Wednesday)
                        alarm.Date += "周三";
                    if (Model.Thursday)
                        alarm.Date += "周四";
                    if (Model.Friday)
                        alarm.Date += "周五";
                    if (Model.Saturday)
                        alarm.Date += "周六";
                    if (string.IsNullOrEmpty(alarm.Date))
                    {
                        if (AyMessageBox.Show("时间间隔至少选一天！", "确认信息") == System.Windows.MessageBoxResult.OK)
                            return;
                    }
                    if (timeSpan.TotalSeconds > 0)
                    {
                        switch (tempint)
                        {
                            case 0:
                                if (Model.Sunday)
                                {
                                    if (Model.HourWarn - DateTime.Now.Hour > 0)
                                    {
                                        alarm.Surplus = (Model.HourWarn - DateTime.Now.Hour).ToString() + "时";
                                    }
                                    else if (Model.MinuteWarn - DateTime.Now.Minute > 0)
                                    {
                                        alarm.Surplus = (Model.MinuteWarn - DateTime.Now.Minute).ToString() + "分";
                                    }
                                    else
                                    {
                                        alarm.Surplus = (Model.SecWarn - DateTime.Now.Second).ToString() + "秒";
                                    }
                                }
                                else if (Model.Monday)
                                    alarm.Surplus = "一天";
                                else if (Model.Tuesday)
                                    alarm.Surplus = "两天";
                                else if (Model.Wednesday)
                                    alarm.Surplus = "三天";
                                else if (Model.Thursday)
                                    alarm.Surplus = "四天";
                                else if (Model.Friday)
                                    alarm.Surplus = "五天";
                                else if (Model.Saturday)
                                    alarm.Surplus = "六天";
                                break;
                            case 1:
                                if (Model.Monday)
                                {
                                    if (Model.HourWarn - DateTime.Now.Hour > 0)
                                    {
                                        alarm.Surplus = (Model.HourWarn - DateTime.Now.Hour).ToString() + "时";
                                    }
                                    else if (Model.MinuteWarn - DateTime.Now.Minute > 0)
                                    {
                                        alarm.Surplus = (Model.MinuteWarn - DateTime.Now.Minute).ToString() + "分";
                                    }
                                    else
                                    {
                                        alarm.Surplus = (Model.SecWarn - DateTime.Now.Second).ToString() + "秒";
                                    }
                                }
                                else if (Model.Tuesday)
                                    alarm.Surplus = "一天";
                                else if (Model.Wednesday)
                                    alarm.Surplus = "两天";
                                else if (Model.Thursday)
                                    alarm.Surplus = "三天";
                                else if (Model.Friday)
                                    alarm.Surplus = "四天";
                                else if (Model.Saturday)
                                    alarm.Surplus = "五天";
                                else if (Model.Sunday)
                                    alarm.Surplus = "六天";
                                break;
                            case 2:
                                if (Model.Tuesday)
                                {
                                    if (Model.HourWarn - DateTime.Now.Hour > 0)
                                    {
                                        alarm.Surplus = (Model.HourWarn - DateTime.Now.Hour).ToString() + "时";
                                    }
                                    else if (Model.MinuteWarn - DateTime.Now.Minute > 0)
                                    {
                                        alarm.Surplus = (Model.MinuteWarn - DateTime.Now.Minute).ToString() + "分";
                                    }
                                    else
                                    {
                                        alarm.Surplus = (Model.SecWarn - DateTime.Now.Second).ToString() + "秒";
                                    }
                                }
                                else if (Model.Wednesday)
                                    alarm.Surplus = "一天";
                                else if (Model.Thursday)
                                    alarm.Surplus = "两天";
                                else if (Model.Friday)
                                    alarm.Surplus = "三天";
                                else if (Model.Saturday)
                                    alarm.Surplus = "四天";
                                else if (Model.Sunday)
                                    alarm.Surplus = "五天";
                                else if (Model.Monday)
                                    alarm.Surplus = "六天";
                                break;
                            case 3:
                                if (Model.Wednesday)
                                {
                                    if (Model.HourWarn - DateTime.Now.Hour > 0)
                                    {
                                        alarm.Surplus = (Model.HourWarn - DateTime.Now.Hour).ToString() + "时";
                                    }
                                    else if (Model.MinuteWarn - DateTime.Now.Minute > 0)
                                    {
                                        alarm.Surplus = (Model.MinuteWarn - DateTime.Now.Minute).ToString() + "分";
                                    }
                                    else
                                    {
                                        alarm.Surplus = (Model.SecWarn - DateTime.Now.Second).ToString() + "秒";
                                    }
                                }
                                else if (Model.Thursday)
                                    alarm.Surplus = "一天";
                                else if (Model.Friday)
                                    alarm.Surplus = "两天";
                                else if (Model.Saturday)
                                    alarm.Surplus = "三天";
                                else if (Model.Sunday)
                                    alarm.Surplus = "四天";
                                else if (Model.Monday)
                                    alarm.Surplus = "五天";
                                else if (Model.Tuesday)
                                    alarm.Surplus = "六天";
                                break;
                            case 4:
                                if (Model.Tuesday)
                                {
                                    if (Model.HourWarn - DateTime.Now.Hour > 0)
                                    {
                                        alarm.Surplus = (Model.HourWarn - DateTime.Now.Hour).ToString() + "时";
                                    }
                                    else if (Model.MinuteWarn - DateTime.Now.Minute > 0)
                                    {
                                        alarm.Surplus = (Model.MinuteWarn - DateTime.Now.Minute).ToString() + "分";
                                    }
                                    else
                                    {
                                        alarm.Surplus = (Model.SecWarn - DateTime.Now.Second).ToString() + "秒";
                                    }
                                }
                                else if (Model.Friday)
                                    alarm.Surplus = "一天";
                                else if (Model.Saturday)
                                    alarm.Surplus = "两天";
                                else if (Model.Sunday)
                                    alarm.Surplus = "三天";
                                else if (Model.Monday)
                                    alarm.Surplus = "四天";
                                else if (Model.Tuesday)
                                    alarm.Surplus = "五天";
                                else if (Model.Wednesday)
                                    alarm.Surplus = "六天";
                                break;
                            case 5:
                                if (Model.Friday)
                                {
                                    if (Model.HourWarn - DateTime.Now.Hour > 0)
                                    {
                                        alarm.Surplus = (Model.HourWarn - DateTime.Now.Hour).ToString() + "时";
                                    }
                                    else if (Model.MinuteWarn - DateTime.Now.Minute > 0)
                                    {
                                        alarm.Surplus = (Model.MinuteWarn - DateTime.Now.Minute).ToString() + "分";
                                    }
                                    else
                                    {
                                        alarm.Surplus = (Model.SecWarn - DateTime.Now.Second).ToString() + "秒";
                                    }
                                }
                                else if (Model.Saturday)
                                    alarm.Surplus = "一天";
                                else if (Model.Sunday)
                                    alarm.Surplus = "两天";
                                else if (Model.Monday)
                                    alarm.Surplus = "三天";
                                else if (Model.Tuesday)
                                    alarm.Surplus = "四天";
                                else if (Model.Wednesday)
                                    alarm.Surplus = "五天";
                                else if (Model.Thursday)
                                    alarm.Surplus = "六天";
                                break;
                            case 6:
                                if (Model.Saturday)
                                {
                                    if (Model.HourWarn - DateTime.Now.Hour > 0)
                                    {
                                        alarm.Surplus = (Model.HourWarn - DateTime.Now.Hour).ToString() + "时";
                                    }
                                    else if (Model.MinuteWarn - DateTime.Now.Minute > 0)
                                    {
                                        alarm.Surplus = (Model.MinuteWarn - DateTime.Now.Minute).ToString() + "分";
                                    }
                                    else
                                    {
                                        alarm.Surplus = (Model.SecWarn - DateTime.Now.Second).ToString() + "秒";
                                    }
                                }
                                else if (Model.Sunday)
                                    alarm.Surplus = "一天";
                                else if (Model.Monday)
                                    alarm.Surplus = "两天";
                                else if (Model.Tuesday)
                                    alarm.Surplus = "三天";
                                else if (Model.Wednesday)
                                    alarm.Surplus = "四天";
                                else if (Model.Thursday)
                                    alarm.Surplus = "五天";
                                else if (Model.Friday)
                                    alarm.Surplus = "六天";
                                break;
                        }
                    }
                    else
                    {
                        switch (tempint)
                        {
                            case 0:
                                if (Model.Monday)
                                {
                                    if (timeSpan.TotalHours >= 1)
                                        alarm.Surplus = ((int)(timeSpan.TotalHours)).ToString() + "时";
                                    else if (timeSpan.TotalMinutes >= 1)
                                        alarm.Surplus = ((int)(timeSpan.TotalMinutes)).ToString() + "分";
                                    else
                                        alarm.Surplus = ((int)(timeSpan.TotalSeconds)).ToString() + "秒";
                                }
                                else if (Model.Tuesday)
                                    alarm.Surplus = "一天";
                                else if (Model.Wednesday)
                                    alarm.Surplus = "两天";
                                else if (Model.Thursday)
                                    alarm.Surplus = "三天";
                                else if (Model.Friday)
                                    alarm.Surplus = "四天";
                                else if (Model.Saturday)
                                    alarm.Surplus = "五天";
                                else if (Model.Sunday)
                                    alarm.Surplus = "六天";
                                break;
                            case 1:
                                if (Model.Tuesday)
                                {
                                    if (timeSpan.TotalHours >= 1)
                                        alarm.Surplus = ((int)(timeSpan.TotalHours)).ToString() + "时";
                                    else if (timeSpan.TotalMinutes >= 1)
                                        alarm.Surplus = ((int)(timeSpan.TotalMinutes)).ToString() + "分";
                                    else
                                        alarm.Surplus = ((int)(timeSpan.TotalSeconds)).ToString() + "秒";
                                }
                                else if (Model.Wednesday)
                                    alarm.Surplus = "一天";
                                else if (Model.Thursday)
                                    alarm.Surplus = "两天";
                                else if (Model.Friday)
                                    alarm.Surplus = "三天";
                                else if (Model.Saturday)
                                    alarm.Surplus = "四天";
                                else if (Model.Sunday)
                                    alarm.Surplus = "五天";
                                else if (Model.Monday)
                                    alarm.Surplus = "六天";
                                break;
                            case 2:
                                if (Model.Wednesday)
                                {
                                    if (timeSpan.TotalHours >= 1)
                                        alarm.Surplus = ((int)(timeSpan.TotalHours)).ToString() + "时";
                                    else if (timeSpan.TotalMinutes >= 1)
                                        alarm.Surplus = ((int)(timeSpan.TotalMinutes)).ToString() + "分";
                                    else
                                        alarm.Surplus = ((int)(timeSpan.TotalSeconds)).ToString() + "秒";
                                }
                                else if (Model.Thursday)
                                    alarm.Surplus = "一天";
                                else if (Model.Friday)
                                    alarm.Surplus = "两天";
                                else if (Model.Saturday)
                                    alarm.Surplus = "三天";
                                else if (Model.Sunday)
                                    alarm.Surplus = "四天";
                                else if (Model.Monday)
                                    alarm.Surplus = "五天";
                                else if (Model.Tuesday)
                                    alarm.Surplus = "六天";
                                break;
                            case 3:
                                if (Model.Thursday)
                                {
                                    if (timeSpan.TotalHours >= 1)
                                        alarm.Surplus = ((int)(timeSpan.TotalHours)).ToString() + "时";
                                    else if (timeSpan.TotalMinutes >= 1)
                                        alarm.Surplus = ((int)(timeSpan.TotalMinutes)).ToString() + "分";
                                    else
                                        alarm.Surplus = ((int)(timeSpan.TotalSeconds)).ToString() + "秒";
                                }
                                else if (Model.Friday)
                                    alarm.Surplus = "一天";
                                else if (Model.Saturday)
                                    alarm.Surplus = "两天";
                                else if (Model.Sunday)
                                    alarm.Surplus = "三天";
                                else if (Model.Monday)
                                    alarm.Surplus = "四天";
                                else if (Model.Tuesday)
                                    alarm.Surplus = "五天";
                                else if (Model.Wednesday)
                                    alarm.Surplus = "六天";
                                break;
                            case 4:
                                if (Model.Friday)
                                {
                                    if (timeSpan.TotalHours >= 1)
                                        alarm.Surplus = ((int)(timeSpan.TotalHours)).ToString() + "时";
                                    else if (timeSpan.TotalMinutes >= 1)
                                        alarm.Surplus = ((int)(timeSpan.TotalMinutes)).ToString() + "分";
                                    else
                                        alarm.Surplus = ((int)(timeSpan.TotalSeconds)).ToString() + "秒";
                                }
                                else if (Model.Saturday)
                                    alarm.Surplus = "一天";
                                else if (Model.Sunday)
                                    alarm.Surplus = "两天";
                                else if (Model.Monday)
                                    alarm.Surplus = "三天";
                                else if (Model.Tuesday)
                                    alarm.Surplus = "四天";
                                else if (Model.Wednesday)
                                    alarm.Surplus = "五天";
                                else if (Model.Thursday)
                                    alarm.Surplus = "六天";
                                break;
                            case 5:
                                if (Model.Saturday)
                                {
                                    if (timeSpan.TotalHours >= 1)
                                        alarm.Surplus = ((int)(timeSpan.TotalHours)).ToString() + "时";
                                    else if (timeSpan.TotalMinutes >= 1)
                                        alarm.Surplus = ((int)(timeSpan.TotalMinutes)).ToString() + "分";
                                    else
                                        alarm.Surplus = ((int)(timeSpan.TotalSeconds)).ToString() + "秒";
                                }
                                else if (Model.Sunday)
                                    alarm.Surplus = "一天";
                                else if (Model.Monday)
                                    alarm.Surplus = "两天";
                                else if (Model.Tuesday)
                                    alarm.Surplus = "三天";
                                else if (Model.Wednesday)
                                    alarm.Surplus = "四天";
                                else if (Model.Thursday)
                                    alarm.Surplus = "五天";
                                else if (Model.Friday)
                                    alarm.Surplus = "六天";
                                break;
                            case 6:
                                if (Model.Sunday)
                                {
                                    if (timeSpan.TotalHours >= 1)
                                        alarm.Surplus = ((int)(timeSpan.TotalHours)).ToString() + "时";
                                    else if (timeSpan.TotalMinutes >= 1)
                                        alarm.Surplus = ((int)(timeSpan.TotalMinutes)).ToString() + "分";
                                    else
                                        alarm.Surplus = ((int)(timeSpan.TotalSeconds)).ToString() + "秒";
                                }
                                else if (Model.Monday)
                                    alarm.Surplus = "一天";
                                else if (Model.Tuesday)
                                    alarm.Surplus = "两天";
                                else if (Model.Wednesday)
                                    alarm.Surplus = "三天";
                                else if (Model.Thursday)
                                    alarm.Surplus = "四天";
                                else if (Model.Friday)
                                    alarm.Surplus = "五天";
                                else if (Model.Saturday)
                                    alarm.Surplus = "六天";
                                break;
                        }
                    }
                    break;
                case "每月":
                    alarm.Date = Model.DaySet + "日";
                    dateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, Model.DaySet, Model.HourWarn, Model.MinuteWarn, Model.MinuteWarn);
                    timeSpan = dateTime - DateTime.Now;
                    if (timeSpan.TotalSeconds > 0)
                    {
                        if(timeSpan.TotalDays>=1)
                            alarm.Surplus = ((int)(timeSpan.TotalDays)).ToString() + "天";
                        else if(timeSpan.TotalHours>=1)
                            alarm.Surplus = ((int)(timeSpan.TotalHours)).ToString() + "时";
                        else if (timeSpan.TotalMinutes >= 1)
                            alarm.Surplus = ((int)(timeSpan.TotalMinutes)).ToString() + "分";
                        else
                            alarm.Surplus = ((int)(timeSpan.TotalSeconds)).ToString() + "秒";
                    }
                    else
                    {
                        if(DateTime.Now.Month==12)
                            dateTime = new DateTime(DateTime.Now.AddYears(1).Year,1, Model.DaySet, Model.HourWarn, Model.MinuteWarn, Model.MinuteWarn);
                        else
                            dateTime = new DateTime(DateTime.Now.AddYears(1).Year, DateTime.Now.AddMonths(1).Month, Model.DaySet, Model.HourWarn, Model.MinuteWarn, Model.MinuteWarn);
                        timeSpan = dateTime - DateTime.Now;
                        alarm.Surplus = ((int)(timeSpan.TotalDays)).ToString() + "天";
                    }
                    break;
                case "每年":
                    alarm.Date = Model.MonthSet + "月" + Model.DaySet + "日";
                    dateTime = new DateTime(DateTime.Now.Year, Model.MonthSet, Model.DaySet, Model.HourWarn, Model.MinuteWarn, Model.MinuteWarn);
                    timeSpan = dateTime - DateTime.Now;
                    if (timeSpan.TotalSeconds > 0)
                    {
                        if(Model.MonthSet-DateTime.Now.Month>0)
                            alarm.Surplus = (Model.MonthSet - DateTime.Now.Month).ToString() + "月";
                        else if(timeSpan.TotalDays>=1)
                            alarm.Surplus = ((int)(timeSpan.TotalDays)).ToString() + "天";
                        else if (timeSpan.TotalHours >= 1)
                            alarm.Surplus = ((int)(timeSpan.TotalHours)).ToString() + "时";
                        else if (timeSpan.TotalMinutes >= 1)
                            alarm.Surplus = ((int)(timeSpan.TotalMinutes)).ToString() + "分";
                        else
                            alarm.Surplus = ((int)(timeSpan.TotalSeconds)).ToString() + "秒";
                    }
                    else
                    {
                        alarm.Surplus = (Model.MonthSet + 11 - DateTime.Now.Month).ToString() + "月";
                    }
                    break;
                case "间隔":
                    if (Model.DaySet + Model.HourSet + Model.MinuteSet + Model.SecSet <= 0)
                    {
                        if (AyMessageBox.Show("时间间隔必须大于60秒！", "确认信息") == System.Windows.MessageBoxResult.OK)
                            return;
                    } 
                    else
                    {
                        if (Model.DaySet > 0)
                            alarm.Date += Model.DaySet + "日";
                        if (Model.HourSet > 0)
                            alarm.Date += Model.HourSet + "时";
                        if (Model.MinuteSet > 0)
                            alarm.Date += Model.MinuteSet + "分";
                        if (Model.SecSet > 0)
                            alarm.Date += Model.SecSet + "秒";
                        dateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, Model.HourWarn, Model.MinuteWarn, Model.MinuteWarn);
                        dateTime.AddDays(Model.DaySet).AddHours(Model.HourSet).AddMinutes(Model.MinuteSet).AddSeconds(Model.SecSet);
                        timeSpan = dateTime - DateTime.Now;
                        if (Model.MonthSet - DateTime.Now.Month > 0)
                            alarm.Surplus = (Model.MonthSet - DateTime.Now.Month).ToString() + "月";
                        else if (timeSpan.TotalDays >= 1)
                            alarm.Surplus = ((int)(timeSpan.TotalDays)).ToString() + "天";
                        else if (timeSpan.TotalHours >= 1)
                            alarm.Surplus = ((int)(timeSpan.TotalHours)).ToString() + "时";
                        else if (timeSpan.TotalMinutes >= 1)
                            alarm.Surplus = ((int)(timeSpan.TotalMinutes)).ToString() + "分";
                        else
                            alarm.Surplus = ((int)(timeSpan.TotalSeconds)).ToString() + "秒";
                    }

                    break;
            }
            alarm.Time = Model.HourWarn + ":" + Model.MinuteWarn + ":" + Model.SecWarn;
            alarm.Task = Model.TaskLab;
            DateTime ii= Model.DateTimeSet;
            AYUI.Message.Send<Alarm>(alarm, "AddAlarm");
        }

        private void ChooseRoundrobin(string v)
        {
            RoundrobinModel = v;
            AYUI.Message.Send<string>(v, "ChooseRoundrobin");
        }

        public ActionResult Roundrobin { get; private set; }
        public ActionResult ApplicationAction { get; private set; }
    }
}
