using Conference.Data.Models;

namespace Conference.Data.Repositories
{
    public interface IUserRepository
    {
        User GetByUsernameAndPassword(string username, string password);
    }
}