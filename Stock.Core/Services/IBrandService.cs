using Stock.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Core.Services
{
   public interface IBrandService<>:IService<Brand>
    {

        //marka id verildiğinde categorileri gösteren method

        Task<Brand> GetWithCategoryById(int brandId);
    }
}
