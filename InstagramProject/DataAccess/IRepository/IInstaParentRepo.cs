using InstagramProject.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InstagramProject.DataAccess.IRepository
{
    public interface IInstaParentRepo
    {
        public Task<List<Instaparent>> GetAllIds();
        
        public Task<Instaparent> GetById(int PId);
        public Task<int> InsertName(Instaparent instaparent);
        public Task<int> UpdateName(Instaparent instaparent);
        public Task<int> DeleteName(int PId);
    }
}
