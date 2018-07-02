using Ay.MvcFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TomatoClock.Models
{
    public class DropDownOption : Model
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
