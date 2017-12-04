namespace testInterface
{
    public class Third: IForecast, IForecast2
    {       
        int IForecast.GetForecast(int value)
        {
            return value + Size;
        }

        public int Size { get; set; }

        int IForecast2.GetForecast(int value)
        {
            return 2 * value + Size;
        }
    }
}