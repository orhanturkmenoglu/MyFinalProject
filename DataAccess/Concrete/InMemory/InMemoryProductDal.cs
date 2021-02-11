using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    // InMemory : bellekte calışacagız
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products; // değişkeni tanımladık referans alınca çalışması ıcın constructor olusturduk
        public InMemoryProductDal()
        {
            _products = new List<Product> {

                new Product{ProductId=1,CategoryId=1,ProductName="Bardak",UnitPrice=15,UnitsInStock=15},
                new Product{ProductId=2,CategoryId=1,ProductName="Kamera",UnitPrice=500,UnitsInStock=3},
                new Product{ProductId=3,CategoryId=2,ProductName="Telefon",UnitPrice=1500,UnitsInStock=2},
                new Product{ProductId=4,CategoryId=2,ProductName="Klavye",UnitPrice=150,UnitsInStock=65},
                new Product{ProductId=5,CategoryId=2,ProductName="Fare",UnitPrice=85,UnitsInStock=1}

            };
        }  // bu constructor calıstıgında oluşacak urunleri yazdık...
        public void Add(Product product)
        {
            _products.Add(product); // ürünümüzü listeye ekledik.
        }

        public void Delete(Product product)
        {
            // LINQ : LANGUAGE INTEGRATED QUERY
            // elimizdeki bilgilerden id bazlı silim işlemi yapacaz.
            // SingleOrDefault(): tek bir eleman bazlı bulmak ıcın kullanırız.genellikle ıd bazlı kullanımlarda
            Product productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId); // tek bir eleman bulmamızı saglar.
            _products.Remove(productToDelete);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            // gonderdigim ürün ıd sıne sahıp olan Listedeki  ürünü bul demek 
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }
    }
}
