using PeriodTracker.BLL.Models;
using PeriodTracker.DAL.Entities;
using System.Collections.Generic;

namespace PeriodTracker.BLL.Interfaces
{
    public interface IUserServices
    {
        public void CreateUser(CreateUserVM createUser);
        public IEnumerable<User> GetUsers();
        public IEnumerable<UserWithTrackerVM> GetUsersWithTrackerVM();

    }
}
