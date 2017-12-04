using System;

namespace testInterface
{
    class Program
    {
        static void Main()
        {
            var first = new First();
            var second = new Second();
            AnyMethod(first);
            AnyMethod(second);
            Console.WriteLine("*************");

            IForecast any;
            var key = Console.ReadKey(true);

            if(key.Key == ConsoleKey.Enter) any = new First();
            else any = new Second();
            Console.WriteLine(any.Size);

            var array = new IForecast[2];
            array[0] = new First();
            array[1] = new Second();
            var summ = 0;
            foreach (var forecast in array)
            {
                summ += forecast.Size;
            }
            Console.WriteLine(summ);

            Console.WriteLine("Base class:");

            IForecast frc;
            frc = new Second();
            var frcBase = (BaseClass) frc;
            var result = frcBase.GetValue(45);
            Console.WriteLine(result);

            Console.WriteLine("two interfeses:");

            var third = new Third {Size = 10};

            var bad = (IForecast) third;
            var good = (IForecast2) third;

            var v1 = bad.GetForecast(100);
            var v2 = good.GetForecast(100);

            Console.WriteLine(v1+v2);

            Console.ReadKey();
        }

        private static void AnyMethod(IForecast anyClass)
        {
            Console.Write(anyClass.GetType() + " ");
            var value = anyClass.GetForecast(10);
            Console.WriteLine(value);
        }
    }
}
