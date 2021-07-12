using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Conference.Data.Entities;
using Conference.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Conference.Data.Repositories
{
    public class ConferenceRepository : IConferenceRepository
    {
        private readonly ConferenceDbContext dbContext;

        public ConferenceRepository(ConferenceDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public Task<List<ConferenceModel>> GetAll()
        {
            return dbContext.Conferences.Include(c => c.Attendees).Select(c => c.ToModel()).ToListAsync();
        }

        public async Task<ConferenceModel> GetById(int id)
        {
            var entity = await dbContext.Conferences.FirstAsync(c => c.Id == id);
            return entity.ToModel();
        }

        public Task<int> Add(ConferenceModel model)
        {
            var entity = Conferences.FromModel(model);
            dbContext.Conferences.Add(entity);
            return dbContext.SaveChangesAsync();
        }
    }
}
