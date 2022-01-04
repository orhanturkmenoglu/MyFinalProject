using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    // Dal : Data access layer.
    // product ile ilgili veritabanında yapacagımız operasyonları içeren arayüz.
   public interface IProductDal :IEntityRepository<Product>
    {
        // buraya ayrıyeten product ile ilgili özel methodları yazarız.


    }
}
