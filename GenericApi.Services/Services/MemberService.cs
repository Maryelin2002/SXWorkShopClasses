using AutoMapper;
using FluentValidation;
using GenericApi.Bl.Dto;
using GenericApi.Model.Entities;
using GenericApi.Model.Repositories;

namespace GenericApi.Services.Services
{
    public interface IMemberService : IBaseService<User, UserDto> { }
    public class MemberService : BaseService<User, UserDto>, IMemberService
    {
        public MemberService(
            IUserRepository repository,
            IMapper mapper,
            IValidator<UserDto> validator) : base(repository, mapper, validator)
        {
        }
    }
}
