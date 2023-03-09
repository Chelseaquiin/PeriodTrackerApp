using System;

namespace PeriodTracker.DAL.Entities
{
    public class Cycle
    {
        public int CycleLength { get; set; }
        public int PeriodLength { get; set; }
        public DateTime StartDate { get; set; }
    }
}
