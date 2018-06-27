using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using Ay.Framework.WPF.Controls;
using Ay.MvcFramework;

namespace TomatoClock.Views.Alarm
{
    /// <summary>
    /// _ViewStartView.xaml 
    /// 创建时间：2017/9/5 11:57:44
    /// </summary>
    public partial class AlarmSeting : AyWindow
    {
        public AlarmSeting()
        {
            InitializeComponent();
            AYUI.Message.Register<string>(this, "ChooseRoundrobin", ChooseRoundrobin);
            string ii=YearSeting.Text;
        }

        private void ChooseRoundrobin(string obj)
        {
            switch (obj)
            {
                case "一次":
                    YearSeting.Visibility = Visibility.Visible;
                    YearLab.Visibility = Visibility.Visible;
                    MonthSeting.Visibility = Visibility.Visible;
                    Monlab.Visibility = Visibility.Visible;
                    DaySeting.Visibility = Visibility.Visible;
                    Daylab.Visibility = Visibility.Visible;
                    EveLab.Visibility = Visibility.Collapsed;
                    SunSeting.Visibility = Visibility.Collapsed;
                    MonSeting.Visibility = Visibility.Collapsed;
                    TueSeting.Visibility = Visibility.Collapsed;
                    WedSeting.Visibility = Visibility.Collapsed;
                    ThuSeting.Visibility = Visibility.Collapsed;
                    FriSeting.Visibility = Visibility.Collapsed;
                    SatSeting.Visibility = Visibility.Collapsed;
                    HourSeting.Visibility = Visibility.Collapsed;
                    HourLab.Visibility = Visibility.Collapsed;
                    MinuteSeting.Visibility = Visibility.Collapsed;
                    Minutelab.Visibility = Visibility.Collapsed;
                    SecondSeting.Visibility = Visibility.Collapsed;
                    SecLab.Visibility = Visibility.Collapsed;
                    AlerLab.Visibility = Visibility.Collapsed;
                    break;
                case "每天":
                    YearSeting.Visibility = Visibility.Collapsed;
                    YearLab.Visibility = Visibility.Collapsed;
                    MonthSeting.Visibility = Visibility.Collapsed;
                    Monlab.Visibility = Visibility.Collapsed;
                    DaySeting.Visibility = Visibility.Collapsed;
                    Daylab.Visibility = Visibility.Collapsed;
                    EveLab.Visibility = Visibility.Visible;
                    SunSeting.Visibility = Visibility.Collapsed;
                    MonSeting.Visibility = Visibility.Collapsed;
                    TueSeting.Visibility = Visibility.Collapsed;
                    WedSeting.Visibility = Visibility.Collapsed;
                    ThuSeting.Visibility = Visibility.Collapsed;
                    FriSeting.Visibility = Visibility.Collapsed;
                    SatSeting.Visibility = Visibility.Collapsed;
                    HourSeting.Visibility = Visibility.Collapsed;
                    HourLab.Visibility = Visibility.Collapsed;
                    MinuteSeting.Visibility = Visibility.Collapsed;
                    Minutelab.Visibility = Visibility.Collapsed;
                    SecondSeting.Visibility = Visibility.Collapsed;
                    SecLab.Visibility = Visibility.Collapsed;
                    AlerLab.Visibility = Visibility.Collapsed;
                    break;
                case "每周":
                    YearSeting.Visibility = Visibility.Collapsed;
                    YearLab.Visibility = Visibility.Collapsed;
                    MonthSeting.Visibility = Visibility.Collapsed;
                    Monlab.Visibility = Visibility.Collapsed;
                    DaySeting.Visibility = Visibility.Collapsed;
                    Daylab.Visibility = Visibility.Collapsed;
                    EveLab.Visibility = Visibility.Collapsed;
                    SunSeting.Visibility = Visibility.Visible;
                    MonSeting.Visibility = Visibility.Visible;
                    TueSeting.Visibility = Visibility.Visible;
                    WedSeting.Visibility = Visibility.Visible;
                    ThuSeting.Visibility = Visibility.Visible;
                    FriSeting.Visibility = Visibility.Visible;
                    SatSeting.Visibility = Visibility.Visible;
                    HourSeting.Visibility = Visibility.Collapsed;
                    HourLab.Visibility = Visibility.Collapsed;
                    MinuteSeting.Visibility = Visibility.Collapsed;
                    Minutelab.Visibility = Visibility.Collapsed;
                    SecondSeting.Visibility = Visibility.Collapsed;
                    SecLab.Visibility = Visibility.Collapsed;
                    AlerLab.Visibility = Visibility.Collapsed;
                    break;
                case "每月":
                    YearSeting.Visibility = Visibility.Collapsed;
                    YearLab.Visibility = Visibility.Collapsed;
                    MonthSeting.Visibility = Visibility.Collapsed;
                    Monlab.Visibility = Visibility.Collapsed;
                    DaySeting.Visibility = Visibility.Visible;
                    Daylab.Visibility = Visibility.Visible;
                    EveLab.Visibility = Visibility.Collapsed;
                    SunSeting.Visibility = Visibility.Collapsed;
                    MonSeting.Visibility = Visibility.Collapsed;
                    TueSeting.Visibility = Visibility.Collapsed;
                    WedSeting.Visibility = Visibility.Collapsed;
                    ThuSeting.Visibility = Visibility.Collapsed;
                    FriSeting.Visibility = Visibility.Collapsed;
                    SatSeting.Visibility = Visibility.Collapsed;
                    HourSeting.Visibility = Visibility.Collapsed;
                    HourLab.Visibility = Visibility.Collapsed;
                    MinuteSeting.Visibility = Visibility.Collapsed;
                    Minutelab.Visibility = Visibility.Collapsed;
                    SecondSeting.Visibility = Visibility.Collapsed;
                    SecLab.Visibility = Visibility.Collapsed;
                    AlerLab.Visibility = Visibility.Collapsed;
                    break;
                case "每年":
                    YearSeting.Visibility = Visibility.Collapsed;
                    YearLab.Visibility = Visibility.Collapsed;
                    MonthSeting.Visibility = Visibility.Visible;
                    Monlab.Visibility = Visibility.Visible;
                    DaySeting.Visibility = Visibility.Visible;
                    Daylab.Visibility = Visibility.Visible;
                    EveLab.Visibility = Visibility.Collapsed;
                    SunSeting.Visibility = Visibility.Collapsed;
                    MonSeting.Visibility = Visibility.Collapsed;
                    TueSeting.Visibility = Visibility.Collapsed;
                    WedSeting.Visibility = Visibility.Collapsed;
                    ThuSeting.Visibility = Visibility.Collapsed;
                    FriSeting.Visibility = Visibility.Collapsed;
                    SatSeting.Visibility = Visibility.Collapsed;
                    HourSeting.Visibility = Visibility.Collapsed;
                    HourLab.Visibility = Visibility.Collapsed;
                    MinuteSeting.Visibility = Visibility.Collapsed;
                    Minutelab.Visibility = Visibility.Collapsed;
                    SecondSeting.Visibility = Visibility.Collapsed;
                    SecLab.Visibility = Visibility.Collapsed;
                    AlerLab.Visibility = Visibility.Collapsed;
                    break;
                case "间隔":
                    YearSeting.Visibility = Visibility.Collapsed;
                    YearLab.Visibility = Visibility.Collapsed;
                    MonthSeting.Visibility = Visibility.Collapsed;
                    Monlab.Visibility = Visibility.Collapsed;
                    DaySeting.Visibility = Visibility.Visible;
                    Daylab.Visibility = Visibility.Visible;
                    EveLab.Visibility = Visibility.Collapsed;
                    SunSeting.Visibility = Visibility.Collapsed;
                    MonSeting.Visibility = Visibility.Collapsed;
                    TueSeting.Visibility = Visibility.Collapsed;
                    WedSeting.Visibility = Visibility.Collapsed;
                    ThuSeting.Visibility = Visibility.Collapsed;
                    FriSeting.Visibility = Visibility.Collapsed;
                    SatSeting.Visibility = Visibility.Collapsed;
                    HourSeting.Visibility = Visibility.Visible;
                    HourLab.Visibility = Visibility.Visible;
                    MinuteSeting.Visibility = Visibility.Visible;
                    Minutelab.Visibility = Visibility.Visible;
                    SecondSeting.Visibility = Visibility.Visible;
                    SecLab.Visibility = Visibility.Visible;
                    AlerLab.Visibility = Visibility.Visible;
                    break;
            }
        }
    }





}
