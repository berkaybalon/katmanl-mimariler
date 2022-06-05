using Business.Abstract;
using DataAccess.Concrete.Memory;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public  class ProductManager : IProductService

    {
        MemoryProductDal _memoryProductDal;

        public ProductManager(MemoryProductDal memoryProductDal)

        {
            _memoryProductDal = memoryProductDal;


        }

        public List<Product> GetAll()
        {
            return _memoryProductDal.GetAll();
        }
    }
}
