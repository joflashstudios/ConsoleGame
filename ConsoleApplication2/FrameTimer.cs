using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class FrameTimer
    {
        private DateTime lastTick = DateTime.Now;

        public TimeSpan GetFrametime()
        {
            DateTime now = DateTime.Now;
            TimeSpan delta = now - lastTick;
            lastTick = now;
            return delta;
        }
    }
}
