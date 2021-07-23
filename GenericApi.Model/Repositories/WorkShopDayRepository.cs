using GenericApi.Model.Contexts;
using GenericApi.Model.Entities;

namespace GenericApi.Model.Repositories
{
    public interface IWorkShopDayRepository : IBaseRepository<WorkShopDay> { }
    public class WorkShopDayRepository : BaseRepository<WorkShopDay>, IWorkShopDayRepository
    {
        public WorkShopDayRepository(WorkShopContext context) : base(context)
        {

        }
    }
}
