using PeriodTracker.BLL.Interfaces;
using PeriodTracker.BLL.Models;
using PeriodTracker.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PeriodTracker.BLL.Implementation
{
    public class UserServices : IUserServices
    {
        public void CreateUser(CreateUserVM createUser)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserWithTrackerVM> GetUsersWithTrackerVM()
        {
            return TrackerDBContext.Users().Select(u => new UserWithTrackerVM
            {
                FullName = u.FullName,
                Trackers = u.UserCycle.Select(t => new TrackerVM 
                { 
                    StartDate = DateTime.Now,

                })
            });
        }

        public IEnumerable<User> GetUsers()
        {
            throw new NotImplementedException();
        }
    }
}
