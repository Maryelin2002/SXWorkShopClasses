using GenericApi.Bl.Dto;
using GenericApi.Model.Entities;
using GenericApi.Services.Services;
using Microsoft.AspNetCore.Mvc;

namespace GenericApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MemberController : BaseController<User, UserDto>
    {
        public MemberController(IMemberService service) : base(service)
        {

        }
    }
}
