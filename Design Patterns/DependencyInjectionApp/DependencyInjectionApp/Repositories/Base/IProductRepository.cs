using DependencyInjectionApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionApp.Repositories.Base
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAll();
        void Create(Product product);
    }
}
