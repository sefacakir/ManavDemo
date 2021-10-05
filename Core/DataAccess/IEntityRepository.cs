using Core.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll();
        T Get();
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}

/*
 *  Core katmanı diğer katmanlardan bağımsız bir katmandır. 
 *  Dolayısıyla burda IEntity'i referans almak yerine Core katmanı içerisine çekiyorum.
 *  Artık generic uygulayabilirim.
 *  
 *  Şimdi bu imzaların içini tek tek doldurabilmem için 2 farklı seçeneğim var.
 *  Ya gidip ICustomerDal içerisinde ve IProductDal içirisinde implemente edip tek tek doldurucam,
 *  yada bir generic yapı daha kullanarak tüm nesneleri aynı anda doldurabilicem.
 */