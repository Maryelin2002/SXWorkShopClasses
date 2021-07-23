using GenericApi.Model.Contexts;
using GenericApi.Model.Entities;

namespace GenericApi.Model.Repositories
{
    public interface IWorkShopRepository : IBaseRepository<WorkShop> {}
    public class WorkShopRepository : BaseRepository<WorkShop>, IWorkShopRepository
    {
        public WorkShopRepository(WorkShopContext context) : base(context)
        {
            
        }
    }
}
