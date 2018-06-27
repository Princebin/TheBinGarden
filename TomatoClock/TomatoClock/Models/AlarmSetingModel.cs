using Ay.MvcFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TomatoClock.Models
{
    public class AlarmSetingModel : Model
    {
        private int _yearSet;
        public AlarmSetingModel()
        {
            YearSet= DateTime.Now.Year;
        }

        public int YearSet
        {
            get => _yearSet;
            set
            {
                Set(ref _yearSet, value);
            }
        }
    }
}
