using Stock.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Core.Repositories
{
   public interface IProductRepository:IRepository<Product>
    {
        //Seçilen ürünün kategorileri  gelsin

        Task<Product> GetWithCategoryById(int productID);

        //seçilen ürünün markası listelensin
        Task<Product> GetWithBrandById(int productID);
    }
}
