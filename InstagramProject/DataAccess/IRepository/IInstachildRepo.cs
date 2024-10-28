using InstagramProject.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InstagramProject.DataAccess.IRepository
{
    public interface IInstachildRepo
    {

        public Task<List<Instachild>> AllSignDetails();
        public Task<Instachild> GetSignUpById(int InstaId);
        public Task<Instachild> GetEmailandPassword(string Email, string Password);
        public Task<int> InsertNames(Instachild signUp);
        public Task<int> UpdateNames(Instachild signUp);
        public Task<int> DeleteNames(int InstaId);
    }
}
