using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Stock.Core.Repositories;

namespace Stock.Core.UnitOfWorks
{
    public interface IUnitOfWorks
    {
        //UnitOfWork EF tarafında yapılan insert update delete komutlarının veritabanına yansıma kısmmını geliştiriciye bırakmasıdır.
        //Geliştrici değişiklik yapıyor.EF bunu hafızada tutuyor.Ve en son vt ye atması gerektiğinde devreye UNIT OF WORK PATTERN giriyor.

        IProductRepository Products { get; set; }

        ICategoryRepository Categories { get; set; }

        IBrandRepository Brands { get; set; }

        ICartRepository Carts { get; set; }

        ICustomerRepository Customers { get; set; }

        IUnitRepository Units { get; set; }

        ISalesRepository Salesies { get; set; }

        Task CommitAsyn();//Save Change denilidğinde bu method gelecek
        void Commit();




    }
}
