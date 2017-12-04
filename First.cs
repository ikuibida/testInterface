namespace testInterface
{
    public class First: IForecast
    {
        public First()
        {
            Size = 100;
        }

        public int GetForecast(int value)
        {
            return value * 2;
        }

        public int Size { get; set; }
    }
}