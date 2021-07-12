using System.Threading.Tasks;
using Conference.Data.Models;

namespace Conference.Data.Repositories
{
    public interface IAttendeeRepository
    {
        Task<int> Add(AttendeeModel attendee);
        Task<int> GetAttendeesTotal(int conferenceId);
    }
}