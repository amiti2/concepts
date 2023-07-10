﻿namespace BlazorServerDemo.Data
{
    public class UtcDemo : IDemo
    {
        public DateTime StartUpTime { get ; init ; }
        public UtcDemo()
        {
            StartUpTime = DateTime.UtcNow;
        }
    }
}
