namespace BlazorServerDemo.Data
{
    public class Demo : IDemo
    {
        public DateTime StartUpTime { get; init; }
        public Demo()
        {
            StartUpTime = DateTime.Now;
        }
    }
}
