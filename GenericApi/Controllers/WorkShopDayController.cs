using GenericApi.Bl.Dto;
using GenericApi.Model.Entities;
using GenericApi.Services.Services;
using Microsoft.AspNetCore.Mvc;

namespace GenericApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WorkShopDayController : BaseController<WorkShopDay, WorkShopDayDto>
    {
        public WorkShopDayController(IWorkShopDayService service) : base(service)
        {

        }
    }
}
