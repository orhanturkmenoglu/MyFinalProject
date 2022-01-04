using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
   public interface ICategoryDal :IEntityRepository<Category>
    {
        // buraya ayrıyeten product ile ilgili özel methodları yazarız.
    }
}
