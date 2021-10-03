using Core.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product>, IProductDal
    {
        
    }
}

/*  
 *  IProductDal içerisindeki işlemler, artık EfEntityRepositoryBase'e taşındı.
 *  Peki bunu neden yaptık;
 *  Eğer yapmasaydık IProductDal içerisindeki metotları implemente etmek zorunda kalacaktık.
 *  Bunda ne sıkıntı var diyecek olursak, bu işlemin aynısını
 *  EfCustomerDal içinde yapmak zorunda olduğumuz.
 *  Aynı kodları aynı işlemleri defalarca kez tekrarlamamak
 *  ve kod tekrarı yapmamak için böyle bir yöntem uyguluyoruz.
 *  
 *  Burda EfEntityRepositoryBase den miras alırken aynı zamanda imzamızın olması için
 *  IProductDal'ı da implemente etmeyi bırakmamalıyız.
 */