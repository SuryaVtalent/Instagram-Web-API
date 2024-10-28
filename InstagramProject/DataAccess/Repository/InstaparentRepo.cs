using InstagramProject.DataAccess.IRepository;
using InstagramProject.DataContext;
using InstagramProject.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InstagramProject.DataAccess.Repository
{
    public class InstaparentRepo:IInstaParentRepo
    {

        public DatabaseContext DBParent;

        public InstaparentRepo(DatabaseContext dbParent) {
            DBParent = dbParent; 
        }

        

        public async Task<List<Instaparent>> GetAllIds()
        {
          return await DBParent.Instaparents.ToListAsync();
        }

        public async Task<Instaparent> GetById(int PId)
        {
           return await DBParent.Instaparents.FindAsync(PId);
        }

        public async Task<int> InsertName(Instaparent instaparent)
        {
            await DBParent.Instaparents.AddAsync(instaparent);
            return await DBParent.SaveChangesAsync();

        }

        public async Task<int> UpdateName(Instaparent instaparent)
        {
            DBParent.Instaparents.Update(instaparent);
            return await DBParent.SaveChangesAsync();

        }

        public async Task<int> DeleteName(int PId)
        {
            var pno = DBParent.Instaparents.Find(PId);
            DBParent.Instaparents.Remove(pno);
            return await DBParent.SaveChangesAsync();

        }
    }
}
