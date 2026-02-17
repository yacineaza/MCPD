using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercice4.Models;


namespace Exercice4.Interfaces


{
    public interface IProductService
    {
        List<Product> GetAll();
        Product GetById(int id);
        List<Product> Filter(string category, double? maxPrice);
    }
}
