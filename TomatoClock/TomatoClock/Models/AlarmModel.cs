using Ay.MvcFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TomatoClock.Models
{
    public class AlarmModel:Model
    {
        private List<Grouping> _groupings;
        private Grouping _groupingItem;

        public AlarmModel()
        {
            Groupings = new List<Grouping>();
            GroupingItem = new Grouping();
        }

        public List<Grouping> Groupings
        {
            get => _groupings;
            set { Set(ref _groupings, value); } 
        }

        public Grouping GroupingItem
        {
            get => _groupingItem;
            set
            {
                Set(ref _groupingItem, value);
            }
        }

    }
    public class Grouping : Model
    {
        private int _key;
        /// <summary>
        /// Key值
        /// </summary>
        public int Key
        {
            get { return _key; }
            set { Set(ref _key, value); }
        }

        private String _text;
        /// <summary>
        /// Text值
        /// </summary>
        public String Text
        {
            get { return _text; }
            set { Set(ref _text, value); }
        }
    }
}
