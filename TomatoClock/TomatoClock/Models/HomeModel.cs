using Ay.MvcFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TomatoClock.Models
{
    public class HomeModel : Model
    {
        private int _tomatoTime;
        private int _restTime;
        private string _alertTime;
        private string _on_off;

        public int TomatoTime
        {
            get => _tomatoTime;
            set
            {
                Set(ref _tomatoTime, value);
            }
        }
        public int RestTime
        {
            get => _restTime;
            set
            {
                Set(ref _restTime, value);
            }
        }
        public string AlertTime
        {
            get => _alertTime;
            set
            {
                Set(ref _alertTime, value);
            }
        }
        public string On_off
        {
            get => _on_off;
            set
            {
                Set(ref _on_off, value);
            }

        }
    }
}
