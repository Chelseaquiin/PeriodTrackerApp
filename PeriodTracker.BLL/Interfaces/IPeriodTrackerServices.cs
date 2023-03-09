namespace PeriodTracker.BLL.Interfaces
{
    public interface IPeriodTrackerServices
    {
        public void PeriodStarts();
        public void PeriodEnds();
        public void FertilityWindow();
        public void SafePeriod();
        public void DelayedPeriod();
        public void EarlyPeriod();
    }
}
