using GenericApi.Model.Contexts;
using GenericApi.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericApi.Model.Repositories
{
    public interface IWorkShopMemberRepository : IBaseRepository<WorkShopMember> { }
    public class WorkShopMemberRepository : BaseRepository<WorkShopMember>, IWorkShopMemberRepository
    {
        public WorkShopMemberRepository(WorkShopContext context) : base(context)
        {

        }
    }
}
