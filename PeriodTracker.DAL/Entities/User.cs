using System;
using System.Collections.Generic;
using System.Text;

namespace PeriodTracker.DAL.Entities
{
    public class User
    {
        public int UserID { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public IList<Cycle> UserCycle { get; set; }
    }
}
