using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whiteboard_Solutions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(TimeAngle(13, 50));
            }
            catch(InvalidOperationException IOE)
            {
                Console.WriteLine(IOE.Message); 
            }
        }

//--------Create a function that will return the difference of angles of a clock's--//
//--------minutes and hour hands are at during a whatever parameters are input.-----//

        public static int TimeAngle(int hour, int minute)
        {
            int hourAngle = 0;
            int minuteAngle = 0;

            if (hour > 23 || hour < 1)
            {
                throw new InvalidOperationException("that is not a valid hour on a clock");
            }
            else if (hour > 12)
            {
                hour -= 12;
            }

            if (minute > 59 || minute < 0)
            {
                throw new InvalidOperationException("that is not a valid minute on a clock");
            }

            minuteAngle = minute * 6;
            hourAngle = hour * 30;
            int angle = hourAngle - minuteAngle;

            if (angle > 180)
            {
                angle -= 180;
            }
            else if (angle < -180)
            {
                angle += 180;
            }
            return Math.Abs(angle);
        }
    }
}
