using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{

    //Eğer bir class IEntity interfacê'ini inherit(kalıtım yoluyla) alıyorsa bu class veritabanında aynı zamanda bir tablodur.

    public class Product : IEntity
    {

        public int Id { get; set; }
        public string ProductName { get; set; }
        public int UnitsInStock { get; set; }
        public int UnitPrice { get; set; }



    }
}
