using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    // NuGet:Paketlerin koyuldugu ortam.Entity framework paket ile dahil olur nuGet ten indirecegiz Paketimizi. nerde
    // calışmak istiyorsak sag tık nuGet ten paket sececez versionumuz 3.1.11

    public class EfProductDal :EfEntityRepositoryBase<Product,NorthwindContext>,IProductDal
    {
     
    }
}
