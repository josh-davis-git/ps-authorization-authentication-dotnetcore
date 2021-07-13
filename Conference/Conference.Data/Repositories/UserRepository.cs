using System.Collections.Generic;
using System.Linq;
using Conference.Data.Models;


namespace Conference.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private List<User> users = new List<User>
        {
            new User { Id = 1, Name = "joshua", Password = "Password123!", Role = "Admin" }
        };

        public User GetByUsernameAndPassword(string username, string password)
        {
            var user = users.SingleOrDefault(u => u.Name == username &&
                u.Password == password);
            return user;
        }

    }
}

