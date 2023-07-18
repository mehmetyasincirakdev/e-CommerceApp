using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product>
            {
                // 1-Elektronik
                // 2-Ev Eşyaları
                // 3-Kişisel Bakım

                new Product { ProductId = 1,  CategoryId = 2,  ProductName = "Televizyon",UnitPrice=6500,UnitsInStock=15},
                new Product { ProductId = 2,  CategoryId = 3,  ProductName = "Buzdolabı", UnitPrice = 4500, UnitsInStock = 10 },
                new Product { ProductId = 3,  CategoryId = 2,  ProductName = "Laptop", UnitPrice = 7500, UnitsInStock = 5 },
                new Product { ProductId = 4,  CategoryId = 1,  ProductName = "Telefon", UnitPrice = 3000, UnitsInStock = 20 },
                new Product { ProductId = 5,  CategoryId = 3,  ProductName = "Çamaşır Makinesi", UnitPrice = 3500, UnitsInStock = 12 },
                new Product { ProductId = 6,  CategoryId = 2,  ProductName = "Tablet", UnitPrice = 2000, UnitsInStock = 8 },
                new Product { ProductId = 7,  CategoryId = 1,  ProductName = "Kulaklık", UnitPrice = 200, UnitsInStock = 50 },
                new Product { ProductId = 8,  CategoryId = 2,  ProductName = "Monitör", UnitPrice = 1500, UnitsInStock = 6 },
                new Product { ProductId = 9,  CategoryId = 3,  ProductName = "Mikrodalga Fırın", UnitPrice = 600, UnitsInStock = 18 },
                new Product { ProductId = 10, CategoryId = 1, ProductName = "Klavye", UnitPrice = 300, UnitsInStock = 30 },
                new Product { ProductId = 11, CategoryId = 2, ProductName = "Projeksiyon Cihazı", UnitPrice = 5000, UnitsInStock = 3 },
                new Product { ProductId = 12, CategoryId = 3, ProductName = "Elektrikli Süpürge", UnitPrice = 800, UnitsInStock = 9 },
                new Product { ProductId = 13, CategoryId = 1, ProductName = "Oyun Konsolu", UnitPrice = 4000, UnitsInStock = 7 },
                new Product { ProductId = 14, CategoryId = 2, ProductName = "Fotoğraf Makinesi", UnitPrice = 2500, UnitsInStock = 4 },
                new Product { ProductId = 15, CategoryId = 3, ProductName = "Cep Telefonu", UnitPrice = 2000, UnitsInStock = 25 }
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete = _products.SingleOrDefault(command => command.ProductId == product.ProductId);
            _products.Remove(productToDelete);

        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAllProductsByCategoryId(int categoryId)
        {
            return _products.Where(command => command.CategoryId == categoryId).ToList();
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(command => command.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitsInStock = product.UnitsInStock;
            productToUpdate.UnitPrice = product.UnitPrice;
        }
    }
}
