using AutoMapper;
using GenericApi.Bl.Dto;
using GenericApi.Model.Entities;
using GenericApi.Model.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericApi.Services.Services
{
    public interface IWorkShopMemberService : IBaseService<WorkShopMember, WorkShopMemberDto> { }
    public class WorkShopMemberService : BaseService<WorkShopMember, WorkShopMemberDto>, IWorkShopMemberService
    {
        public WorkShopMemberService(IWorkShopMemberRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
