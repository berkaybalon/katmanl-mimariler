//Business, DataAccess ve Entity sınıf kitaplığı olarak açtık, açtığımızda gelen class1'i sildik. Bunların hepsi birbiriyle haberleşicek.
//içlerinde Abstract ve Concrete diye iki klasör açtık.
//Ürünü Entity'e oluşturuyoruz. Sonra orada Concrete içinde Product adıyla bi class açtık. Sonra Abstract içine IEntity adıyla bir interface ekledik.

using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.Memory;

IProductService _productService = new ProductManager(new MemoryProductDal());

var products = _productService.GetAll();

foreach (var product in products)

{
    Console.WriteLine(product.ProductName);

}



