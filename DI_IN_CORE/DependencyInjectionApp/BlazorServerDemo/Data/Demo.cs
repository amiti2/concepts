namespace BlazorServerDemo.Data
{
    public class Demo : IDemo, ILocalDemo
    {
        public DateTime StartUpTime { get; init; }
        public Demo()
        {
            StartUpTime = DateTime.Now;
        }
    }
}
