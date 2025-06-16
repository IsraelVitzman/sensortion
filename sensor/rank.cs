using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sensor
{
    internal class rank
    {
        Dictionary<String, int> ranks;

        public rank() 
        {
            ranks = new Dictionary<string, int>()
            {
               { "Foot Soldier", 2 },
               { "Squad Leader", 4 },
               { "Senior Commander", 8 },
               { "Organization Leader", 10 }
            };

        }
        public string getRank()
        {
            foreach (int key in ranks.Values)
            {
                if (key == 0)
                {
                    // צריך טיפול זה לא יעב דוד כי הוא מביא סתם סטרינג לא ברור
                    return key.ToString();
                }
            }
            return "";

        }

    }
}
