using Business.Abstract;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        private readonly IBrandService _brand;

        public BrandsController(IBrandService brand)
        {
            _brand = brand;
        }

        [HttpPost]
        public IActionResult Add(CreateBrandRequest createBrandRequest)
        {
            var value = _brand.Add(createBrandRequest);
            return Created("",value);
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_brand.GetAll());
        }
    }
}

//404 başarısız
//401 yetki olmadığından dolayı başarısız
//200 başarılı
//201 başarılı ve eklendi