using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01_Advanced
{
    internal class Range <T> where T : IComparable <T> , INumber<T>
    {
        public T Max { get; set; }
        public T Min { get; set; }

        public Range(T min, T max)
        {
            Max = max;
            Min = min;
        }

        public bool IsInRange(T Num)
        {
            return Num.CompareTo(Min) >= 0 && Num.CompareTo(Max) <=0 ;
        }

        public T Length => Max - Min;


    }
}
