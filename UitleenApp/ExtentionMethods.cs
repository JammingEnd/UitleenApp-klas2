using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UitleenApp
{
    public static class ExtentionMethods
    {
        public static bool SwitchBool(this bool input)
        {
            bool switchItem;
            if (input == true)
            {
                switchItem = false;
                return switchItem;
            }
            if(input == false)
            {
                switchItem = true;
                return switchItem;
            }
            return false;
        }
    }
}
