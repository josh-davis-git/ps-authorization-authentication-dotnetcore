using System.Threading.Tasks;
using Conference.Data;
using Conference.Data.Entities;
using Conference.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Conference.Data.Repositories
{
    public class AttendeeRepository : IAttendeeRepository
    {
        private readonly ConferenceDbContext dbContext;

        public AttendeeRepository(ConferenceDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Task<int> Add(AttendeeModel attendee)
        {
            var entity = Attendee.FromModel(attendee);
            dbContext.Attendees.Add(entity);
            return dbContext.SaveChangesAsync();
        }

        public Task<int> GetAttendeesTotal(int conferenceId)
        {
            return dbContext.Attendees.CountAsync(a => a.ConferenceId == conferenceId);
        }
    }
}
