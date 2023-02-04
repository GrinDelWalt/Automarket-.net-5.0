using Automarket.DAL.Interfeces;
using Automarket.Domain.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Automarket.DAL.Repository
{
    public class ImageRepository : IBaseRepository<Image>
    {
        private readonly ApplicationDbContext _db;

        public ImageRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public Task<bool> Create(Image entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> Delete(Image entity)
        {
            throw new System.NotImplementedException();
        }

        public IQueryable<Image> GetAll()
        {
            return _db.Images;
        }

        public Task<Image> Update(Image entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
