using GenericApi.Bl.Dto;
using GenericApi.Model.Entities;
using GenericApi.Services.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WorkShopController : BaseController<WorkShop, WorkShopDto>
    {
        public WorkShopController(IWorkShopService service) : base(service)
        {

        }
    }
}
