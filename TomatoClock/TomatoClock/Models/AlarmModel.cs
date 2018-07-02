using Ay.MvcFramework;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace TomatoClock.Models
{
    public class AlarmModel:Model
    {
        private List<DropDownOption> _groupings;
        private DropDownOption _groupingItem;
        private ObservableCollection<Alarm> _observableCollection;
        private Alarm alarm;
        public AlarmModel()
        {
            Groupings = new List<DropDownOption>();
            GroupingItem = new DropDownOption();
            ObservableCollection = new ObservableCollection<Alarm>();
        }

        public List<DropDownOption> Groupings
        {
            get => _groupings;
            set { Set(ref _groupings, value); } 
        }

        public DropDownOption GroupingItem
        {
            get => _groupingItem;
            set
            {
                Set(ref _groupingItem, value);
            }
        }

        public ObservableCollection<Alarm> ObservableCollection
        {
            get => _observableCollection;
            set
            {
                Set(ref _observableCollection, value);
            }
        }

        public Alarm Alarm
        {
            get => alarm;
            set
            {
                Set(ref alarm, value);
            }
        }
    }
    public class Alarm : Model
    {
        string _frequency;
        string _date;
        string _time;
        string _task;
        string _surplus;
        bool _swich;
        bool _isShow;

        public string Frequency
        {
            get => _frequency;
            set
            {
                Set(ref _frequency, value);
            }
        }
        public string Date
        {
            get => _date;
            set
            {
                Set(ref _date, value);
            }
        }
        public string Time
        {
            get => _time;
            set
            {
                Set(ref _time, value);
            }
        }
        public string Task
        {
            get => _task;
            set
            {
                Set(ref _task, value);
            }
        }
        public string Surplus
        {
            get => _surplus;
            set
            {
                Set(ref _surplus, value);
            }
        }
        public bool Swich
        {
            get => _swich;
            set
            {
                Set(ref _swich, value);
            }
        }

        public bool IsShow
        {
            get => _isShow;
            set
            {
                Set(ref _isShow, value);
            }
        }
    }
}
