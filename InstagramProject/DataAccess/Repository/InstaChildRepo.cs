using InstagramProject.DataAccess.IRepository;
using InstagramProject.DataContext;
using InstagramProject.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstagramProject.DataAccess.Repository
{
    public class InstaChildRepo:IInstachildRepo
    {
        public DatabaseContext ChildRep;
        public InstaChildRepo(DatabaseContext childRep)
        {
            ChildRep = childRep;
        }

        public async Task<List<Instachild>> AllSignDetails()
        {
          return await ChildRep.Instachilds.ToListAsync();
        }

       
        public async Task<Instachild> GetEmailandPassword(string Email, string Password)
        {
         return await  ChildRep.Instachilds.Where(x => x.Email == Email && x.Password == Password).SingleOrDefaultAsync();
        }

        public async Task<Instachild> GetSignUpById(int InstaId)
        {
          return await ChildRep.Instachilds.FindAsync(InstaId);
        }

        public async Task<int> InsertNames(Instachild signUp)
        {
          await  ChildRep.Instachilds.AddAsync(signUp);
            return await ChildRep.SaveChangesAsync();

        }

        public async Task<int> UpdateNames(Instachild signUp)
        {
            ChildRep.Instachilds.Update(signUp);
            return await ChildRep.SaveChangesAsync();
        }

        public async Task<int> DeleteNames(int InstaId)
        {
            var cno = ChildRep.Instachilds.Find(InstaId);
            ChildRep.Instachilds.Remove(cno);
            return await ChildRep.SaveChangesAsync();
        }

    }
}
