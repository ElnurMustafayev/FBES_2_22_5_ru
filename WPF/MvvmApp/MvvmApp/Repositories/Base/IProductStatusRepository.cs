using MvvmApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmApp.Repositories.Base
{
    public interface IProductStatusRepository
    {
        IEnumerable<ProductStatus> GetAll();
    }
}
