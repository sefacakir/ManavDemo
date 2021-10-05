using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using Core.Utilities.Results.Concrete.SuccessResults;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal; 

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
            //burdan IEntityRepository içerisindeki ekle metodu çalışmakta.
        } 

        public IResult Add(Product product)
        {
            //Burda gerekli karşılaştırmalar yapıldı ve eklenmesinde bir sakınca görülmedi.
            _productDal.Add(product);
            return new SuccessResult(Messages.ProductAdded);
            //ekledikten sonra bana bir mesaj vermesini istiyorum.
        }

        public IResult Delete(Product product)
        {
            _productDal.Delete(product);
            return new SuccessResult(Messages.MaintenanceTime);
        }

        public IResult Update(Product product)
        {
            _productDal.Update(product);
            return new ErrorResult(Messages.ProductNameInvalid);

        }
    }
}
