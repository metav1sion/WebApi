using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete
{
    public class BrandDal : IBrandDal
    {
        private List<Brand> _brands;

        public BrandDal()
        {
            _brands = new List<Brand>();
            _brands.Add(new Brand{Id = 1, Name = "BMW", CreatedDate = DateTime.Now});
            _brands.Add(new Brand{Id = 2, Name = "Mercedes", CreatedDate = DateTime.Now});
            _brands.Add(new Brand{Id = 3, Name = "Opel", CreatedDate = DateTime.Now});
            _brands.Add(new Brand{Id = 4, Name = "Peugeout", CreatedDate = DateTime.Now});
            _brands.Add(new Brand{Id = 5, Name = "DS", CreatedDate = DateTime.Now});
            _brands.Add(new Brand{Id = 6, Name = "Citroen", CreatedDate = DateTime.Now});
        }

        public void Add(Brand brand)
        {
            _brands.Add(brand);
        }

        public List<Brand> GetAll()
        {
            return _brands.ToList();
        }
    }
}
