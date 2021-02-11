using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        // Bir iş sınıfı başka sınıfları newlemez constructor parametre olarak geçeriz constructor enjection ;
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public IResult Add(Product product)
        {
            // İş kodları yazılır.(business codes)
            // Messages.ProductNameInvalid : mesajlarımızı sabit classa yazdık ordan yonetiyoruz 
            if (product.ProductName.Length<2)
            {
                return new ErrorResult(Messages.ProductNameInvalid); // hatayı kontrol etmış olduk.
            }

            _productDal.Add(product);
            // result referansını tuttugu için dondurmemız sıkıntı olmaz işlem ve sonucu dondurecez burda.
            /*return new Result(true,"Ürün eklendi");*/

            // iki parametre gonderdgimiz zaman çalısacak olan kod default true yine
            return new SuccessResult(Messages.ProductAdded);

            // tek parametre gonderdigiimiz zaman default true göndermiş olduk
            /*return new SuccessResult();*/
        }

        public IDataResult<List<Product>> GetAll()
        {
            // iş kodları 

            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult();
            }
            {

            }

            return new SuccessDataResult<List<Product>>(_productDal.GetAll(),true,"Ürünler listelendi");
        }

        public List<Product> GetAllByCategoryId(int id)
        {
            return _productDal.GetAll(p => p.CategoryId == id);
        }

        public Product GetById(int productId)
        {
            return _productDal.Get(p=>p.ProductId==productId);
        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            return _productDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max);
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            return _productDal.GetProductDetails();
        }

       
    }
}
