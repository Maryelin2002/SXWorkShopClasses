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
    public class BaseController<TEntity, TDto> : ControllerBase
    {

    }
}
