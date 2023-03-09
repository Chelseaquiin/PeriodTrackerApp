using System;
using System.Collections.Generic;

namespace PeriodTracker.DAL.Entities
{
    public class TrackerDBContext
    {
        public static IList<User> Users()
        {
            return new List<User>()
            {
                new User()
                {
                    UserID = 1,
                    FullName = "Maka",
                    Email = "makarene@gmail.com",
                    Password = "1234",
                    UserCycle = new List<Cycle>()
                    {
                        new Cycle()
                        {
                        CycleLength = 28,
                        PeriodLength = 5,
                        StartDate = DateTime.Now.AddDays(-28)
                        },
                        new Cycle()
                        {
                        CycleLength = 28,
                        PeriodLength = 5,
                        StartDate = DateTime.Now.AddDays(28)
                        }
                    }
                },
                new User()
                {
                    UserID = 2,
                    FullName = "Chichi",
                    Email = "chichi@gmail.com",
                    Password = "2341",
                    UserCycle = new List<Cycle>()
                    {
                        new Cycle
                        {
                        CycleLength = 26,
                        PeriodLength = 3
                        }

                    }
                }
            };
        }
    }
}
