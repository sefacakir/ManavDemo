using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        void Add(Customer customer);
        void Delete(Customer customer);
        void Update(Customer customer);

    }
}

/*  IProductService 'teki tüm fonksiyonları burada bir kez daha yazıcak olmamız kod tekrarı demektir.
 *  Bunun önüne geçmek için generic yapıları kullanmalıyız.
 */
