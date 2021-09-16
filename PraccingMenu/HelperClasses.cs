using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraccingMenu
{
    public class StringPair
    {
        public string String1 { get; set; }
        public string String2 { get; set; }

        public StringPair(string string1)
        {
            String1 = string1;
        }

        public StringPair(string string1, string string2)
        {
            String1 = string1;
            String2 = string2;
        }
    }

    
}
