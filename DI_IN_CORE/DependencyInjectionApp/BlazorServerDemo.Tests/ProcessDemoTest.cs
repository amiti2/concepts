using BlazorServerDemo.Data;

namespace BlazorServerDemo.Tests
{
    public class ProcessDemoTest
    {
        [Fact]
        public void GetDaysInMonth_ShouldReturnProperNumberForLearYear()
        {
            DateTime d = DateTime.Parse("2/2/2000");
            TestDemo testDemo = new(d);
            ProcessDemo processDemo = new(testDemo);
            int expected = 29;
            int actual = processDemo.GetDaysInMonth();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetDaysInMonth_ShouldReturnProperNumberForNonLearYear()
        {
            DateTime d = DateTime.Parse("2/2/2001");
            TestDemo testDemo = new(d);
            ProcessDemo processDemo = new(testDemo);
            int expected = 28;
            int actual = processDemo.GetDaysInMonth();
            Assert.Equal(expected, actual);
        }
    }

    public class TestDemo : IDemo
    {
        public DateTime StartUpTime { get ; init; }
        public TestDemo(DateTime dateTime)
        {
            StartUpTime = dateTime;
        }
    }
}