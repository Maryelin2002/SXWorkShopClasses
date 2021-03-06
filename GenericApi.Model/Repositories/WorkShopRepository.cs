using GenericApi.Model.Contexts;
using GenericApi.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
