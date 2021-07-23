﻿using GenericApi.Model.Contexts;
using GenericApi.Model.Entities;

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
