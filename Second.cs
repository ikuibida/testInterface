using System;

namespace testInterface
{
    public class Second: BaseClass, IForecast
    {
        public Second()
        {
            Size = 200;
        }

        public int GetForecast(int value)
        {
            return value / 2;
        }

        public int Size { get; set; }
    }
}