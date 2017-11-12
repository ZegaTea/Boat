using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boat.Util
{
    class DateUtils
    {
        public static long getTimeInMilis()
        {
            return (long)(DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalMilliseconds;
        }

        public static string getDateTime(long milis)
        {
            var y = DateTime.SpecifyKind(new DateTime(1970, 1, 1), DateTimeKind.Local).AddMilliseconds(milis + (3600000 * 7));
            return y.ToString("yyyy-MM-dd  HH:mm:ss");
        }
    }
}
