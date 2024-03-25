using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        [HttpPost]
        public CreatedBrandResponse Add(CreateBrandRequest createBrandRequest)
        {

        }
    }
}
