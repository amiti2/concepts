namespace BlazorServerDemo.Data
{
    public class ProcessDemo
    {
        private readonly IDemo _demo;

        public ProcessDemo(IDemo demo)
        {
            _demo = demo;
        }

        public int GetDaysInMonth()
        {
            return _demo.StartUpTime.Month switch
            {
                1 => 31,
                2 => _demo.StartUpTime.Year % 4 == 0? 29:28,
                3 => 31,
                4 => 30,
                5 => 31,
                6 => 30,

                7 => 31,
                8 => 30,
                9 => 31,
                10 => 31,
                11 => 30,
                12 => 31,
                _ => throw new IndexOutOfRangeException()
            };
        }
    }
}
