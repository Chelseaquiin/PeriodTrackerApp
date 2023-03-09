using System.Collections.Generic;

namespace PeriodTracker.BLL.Models
{
    public class UserWithTrackerVM
    {
        public string FullName { get; set; }
        public IEnumerable<TrackerVM> Trackers { get; set; }
    }
}
