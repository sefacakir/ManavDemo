using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results.Abstract
{
    public interface IDataResult<T> : IResult   //IDataResult geriye veri döndüren işlemlerde kullanılacak.
    {
        T Data { get; }
    }
}
