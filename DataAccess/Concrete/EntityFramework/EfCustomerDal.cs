using Core.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal:EfEntityRepositoryBase<Customer>,ICustomerDal
    {

    }
}

/*
 *  EfCustomerDal, EfProductDal gibi veri erişim kodlarını her biri için ayrı ayrı yazmam gerekiyor.
 *  Ama bunun bir çözümü var, oda generic yapıları kullanmak.
 *  Bunun için Core katmanına EntityFramework adında bir klasör oluşturup içerisinde 
 *  IEntitiyRepositoryBase bırakıyorum. Ama unutmuyorumki bu bir generic yapı.
 */