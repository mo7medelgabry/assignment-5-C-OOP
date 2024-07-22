using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_5_C__OOP.Project3
{
    internal class Duration

    {
        public int Hour { get; set; }
        public int Minute { get; set; }
        public int Second { get; set; }

        public Duration(int hour, int minute, int second)
        {
            Hour = hour;
            Minute = minute;
            Second = second;
        }
        public Duration(int totalSeconds)
        {
            Hour = totalSeconds / 3600;
            Minute = (totalSeconds % 3600) / 60;
            Second = totalSeconds % 60;
        }



        public override string ToString() 
        {
            return $"{Hour}:{Minute}:{Second}";
        }
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Duration other = (Duration)obj;
            return Hour == other.Hour && Minute == other.Minute && Second == other.Second;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Hour, Minute, Second);
        }

    }
}
