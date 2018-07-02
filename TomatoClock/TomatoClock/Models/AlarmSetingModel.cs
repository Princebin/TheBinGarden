using Ay.MvcFramework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TomatoClock.Models
{
    public class AlarmSetingModel : Model
    {
        private DateTime _dateTimeSet;
        private int _yearSet;
        private int _monthSet;
        private int _daySet;
        private bool _sunday;
        private bool _monday;
        private bool _tuesday;
        bool _wednesday;
        bool _thursday;
        bool _friday;
        bool _saturday;
        int _hourSet;
        int _minuteSet;
        int _secSet;
        int _hourWarn;
        int _minuteWarn;
        int _secWarn;
        string _taskLab;
        private List<DropDownOption> _dropDownOptions;
        private DropDownOption _dropDownOption;
        public AlarmSetingModel()
        {
            DateTimeSet = DateTime.Now;
            YearSet = DateTime.Now.Year;
            MonthSet = DateTime.Now.Month;
            DaySet = DateTime.Now.Day;
            Sunday = true;
            Monday = true;
            Tuesday = true;
            Wednesday = true;
            Thursday = true;
            Friday = true;
            Saturday = true;
            HourSet = DateTime.Now.Hour;
            MinuteSet = DateTime.Now.Minute;
            SecSet = DateTime.Now.Second;
            HourWarn = DateTime.Now.Hour;
            MinuteWarn = DateTime.Now.Minute;
            SecWarn = DateTime.Now.Second;
            TaskLab = string.Empty;
            DropDownOptions = new List<DropDownOption> { new DropDownOption { Key = 0, Text = "默认" } };
            DropDownOption = DropDownOptions.FirstOrDefault();
        }

        public int YearSet
        {
            get => _yearSet;
            set
            {
                Set(ref _yearSet, value);
            }
        }

        public int MonthSet
        {
            get => _monthSet;
            set
            {
                Set(ref _monthSet, value);
            }
        }

        public int DaySet
        {
            get => _daySet;
            set
            {
                Set(ref _daySet, value);
            }
        }

        public bool Sunday
        {
            get => _sunday;
            set
            {
                Set(ref _sunday, value);
            }
        }

        public bool Monday
        {
            get => _monday;
            set
            {
                Set(ref _monday, value);
            }
        }
        public bool Tuesday
        {
            get => _tuesday;
            set
            {
                Set(ref _tuesday, value);
            }
        }
        public bool Wednesday
        {
            get => _wednesday;
            set
            {
                Set(ref _wednesday, value);
            }
        }
        public bool Thursday
        {
            get => _thursday;
            set
            {
                Set(ref _thursday, value);
            }
        }
        public bool Friday
        {
            get => _friday;
            set
            {
                Set(ref _friday, value);
            }
        }
        public bool Saturday
        {
            get => _saturday;
            set
            {
                Set(ref _saturday, value);
            }
        }

        public int HourSet
        {
            get => _hourSet;
            set
            {
                Set(ref _hourSet, value);
            }
        }
        public int MinuteSet
        {
            get => _minuteSet;
            set
            {
                Set(ref _minuteSet, value);
            }
        }
        public int SecSet
        {
            get => _secSet;
            set
            {
                Set(ref _secSet, value);
            }
        }

        public int HourWarn
        {
            get => _hourWarn;
            set
            {
                Set(ref _hourWarn, value);
            }
        }
        public int MinuteWarn
        {
            get => _minuteWarn;
            set
            {
                Set(ref _minuteWarn, value);
            }
        }
        public int SecWarn
        {
            get => _secWarn;
            set
            {
                Set(ref _secWarn, value);
            }
        }

        public string TaskLab
        {
            get => _taskLab;
            set
            {
                Set(ref _taskLab, value);
            }
        }

        public List<DropDownOption> DropDownOptions
        {
            get => _dropDownOptions;
            set
            {
                Set(ref _dropDownOptions, value);
            }
        }
        public DropDownOption DropDownOption
        {
            get => _dropDownOption;
            set
            {
                Set(ref _dropDownOption, value);
            }
        }

        public DateTime DateTimeSet
        {
            get => _dateTimeSet;
            set
            {
                Set(ref _dateTimeSet, value);
            }
        }
    }
}
