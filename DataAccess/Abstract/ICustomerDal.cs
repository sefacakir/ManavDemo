using Core;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICustomerDal:IEntityRepository<Customer>
    {

    }
}

/*
 * burada IProductDal içerisindeki tüm metotları tekrar tanımlamamız gerekiyor.
 * Burda generic yapılar sayesinde bundan kurtulabiliriz.
 * Bu generic yapıları tanımlamak için bir Core katmanı oluşturalım
 * Ve bu Core katmanı bizim bu ve diğer projelerde de özgür bir şekilde
 * kullanabileceğimiz bir yapı olmalı.
 * IEntityRepository bizim imzamız, interface'miz.
 */