using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        private readonly IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public CreatedBrandResponse Add(CreateBrandRequest createBrandRequest)
        {
            //business rules

            //mapping --> automapper
            Brand brand = new Brand();
            brand.Name = createBrandRequest.Name;
            brand.CreatedDate = DateTime.Now;
            _brandDal.Add(brand);

            //mapping --> automapper
            CreatedBrandResponse created = new CreatedBrandResponse();
            created.Name = brand.Name;
            created.Id = 7;
            created.CreatedDate = brand.CreatedDate;

            return created;
        }

        public List<GetAllBrandResponse> GetAll()
        {
            List<Brand> brands =  _brandDal.GetAll();
            List<GetAllBrandResponse> getAll = new List<GetAllBrandResponse>();

            foreach (var brand in brands)
            {
                GetAllBrandResponse allBrand = new GetAllBrandResponse();
                allBrand.Name = brand.Name;
                allBrand.CreatedDate = brand.CreatedDate;
                allBrand.Id = brand.Id;

                getAll.Add(allBrand);
            }

            return getAll;
        }
    }
}
