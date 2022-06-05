using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Memory
{
    public class MemoryProductDal : IProductDal
    {

        List<Product> _products;

        
        public MemoryProductDal()
        {
            _products = new List<Product>
            {
               

                new Product {Id=1, ProductName="Mouse", UnitPrice=200, UnitsInStock=34 },
                new Product {Id=2, ProductName="Hoparlör", UnitPrice=400, UnitsInStock=10 },
                new Product {Id=3, ProductName="Kulaklık", UnitPrice=150, UnitsInStock=22 },
                new Product {Id=4, ProductName="Klavye", UnitPrice=345, UnitsInStock=24 }
                //son üründen sonra virgül koymaya gerek yok.

            };

        }

        public void Add(Product product)
        {
            _products.Add(product);

        }

        public void Delete(Product product)
        {

            Product productToDelete = _products.SingleOrDefault(p => p.Id == product.Id);
            _products.Remove(productToDelete);

        }

        public List<Product> GetAll()
        {

            return _products;


        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }


    }
}
