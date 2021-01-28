using Stock.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Core.Services
{
  public  interface ICategoryService:IService<Category>
    {


        //bir categori id verildiğinde hem category hemde on bağlı ürün listesi gelmesi için bir method yazıyoruz.
        Task<Category> GetWithProductsByIdAsync(int categoryID);


    }
}
