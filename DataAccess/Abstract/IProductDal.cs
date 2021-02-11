using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    // Product tablosuna ait  interfacesi ( DAL: DATA ACCESS LAYER ) 
    // product la ilgili veritabanı işlemleri yapacagımız operasyonlar burda.
    public interface IProductDal :IEntityRepository<Product>
    {
        // Ürüne özel özel operasyonları artık bunun içinde yazacagız.

        List<ProductDetailDto> GetProductDetails();
    }
}
