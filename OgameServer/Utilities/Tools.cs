using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgameServer.Utilities
{
    static public class Tools
    {
        /// <summary>
        /// Build the time stamp.
        /// </summary>
        /// <returns>Time stamp of the current time.</returns>
        static public string BuildTimeStamp()
        {
            string time = DateTime.Now.ToString("HH:mm:ss");

            string timeStamp = '[' + time + ']';

            return timeStamp;
        }
    }
}
