using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUseControl.Helpers
{
    public class DateTimeHelper
    {
        public static string GetSeasonOfTheYear(int month)
        {
            if (month == 12)
            {
                return "Winter";
            }

            if (month > 8)
            {
                return "Fall";
            }

            if (month > 5)
            {
                return "Summer";
            }

            if (month > 2)
            {
                return "Spring";
            }

            return "Winter";
        }
    }
}
