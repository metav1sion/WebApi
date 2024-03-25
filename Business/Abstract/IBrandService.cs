using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Dtos.Requests;
using Business.Dtos.Responses;

namespace Business.Abstract
{
    public interface IBrandService
    {
        CreatedBrandResponse Add(CreateBrandRequest createBrandRequest);
        List<GetAllBrandResponse> GetAll();

    }
}
//responses and request
//yanıtlar ve istekler