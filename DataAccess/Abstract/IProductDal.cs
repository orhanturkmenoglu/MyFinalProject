using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    // Product tablosuna ait  interfacesi ( DAL: DATA ACCESS LAYER ) 
    // product la ilgili veritabanı işlemleri yapacagımız operasyonlar burda.
    public interface IProductDal
    {
        List<Product> GetAll();  // Ürünleri Listele dedilk ve artık bu interface product classına bagımlı hale geldi.
        void Add(Product product); 
        void Update(Product product);
        void Delete(Product product);

        List<Product> GetAllByCategory(int categoryId); // ürünleri categoryId sine göre getir.
    }
}
