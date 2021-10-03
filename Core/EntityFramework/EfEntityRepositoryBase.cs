using Core.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity> : IEntityRepository<TEntity>
        where TEntity:class,IEntity,new()
    {
        public void Add(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public TEntity Get()
        {
            throw new NotImplementedException();
        }

        public List<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}

/*  
 *  where kısmı ile TEntity'e bazı şartlar koydum.
 *  Bunlardan biri class olucak. IEntity imzası taşıyacak, ve ayrıca newlenebilecek.
 *  Bu newlenebilecek kısmı şurdan kaynaklanıyor: IEntity de diğer iki şarta uyuyor
 *  IEntity verememek için new şartını getiriyoruz. Bildiğimiz gibi;
 *  İNTERFACE'LER NEW'LENEMEZLER.
 */