using System.Collections.Generic;
using System.Threading.Tasks;
using Conference.Data.Models;

namespace Conference.Data.Repositories
{
    public interface IConferenceRepository
    {
        Task<int> Add(ConferenceModel model);
        Task<List<ConferenceModel>> GetAll();
        Task<ConferenceModel> GetById(int id);
    }
}