using Exercice4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 using Exercice4.Interfaces;



namespace Exercice4.Services

{
    
        public class ProductService : IProductService
        {
            private List<Product> _products;

            public ProductService()
            {
                _products = new List<Product>
            {
                new Product { Id = 1, Name = "Laptop", Category = "Informatique", Price = 1200 },
                new Product { Id = 2, Name = "Souris", Category = "Informatique", Price = 25 },
                new Product { Id = 3, Name = "Chaise", Category = "Mobilier", Price = 150 },
                new Product { Id = 4, Name = "Table", Category = "Mobilier", Price = 300 }
            };
            }

            public List<Product> GetAll()
            {
                return _products;
            }

            public Product GetById(int id)
            {
                Product product = _products.FirstOrDefault(p => p.Id == id);
                return product;
            }

            public List<Product> Filter(string category, double? maxPrice)
            {
                IEnumerable<Product> query = _products;

                if (!string.IsNullOrEmpty(category))
                {
                    query = query.Where(p => p.Category == category);
                }

                if (maxPrice.HasValue)
                {
                    query = query.Where(p => p.Price <= maxPrice.Value);
                }

                return query.ToList();
            }
        }
    }

