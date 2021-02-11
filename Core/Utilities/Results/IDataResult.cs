using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    // IDataResult : hem data hem mesaj hem işlem başarılımı başarısızmı onu donderecek. 
    // Aynı zamanda sen bir IResult implementasyonusun dedik çünkü IResult mesaj ve başarılımı başarısızmı onları tutuyor
    // kendimizi tekrar etmemiş oluyoruz.
   public interface IDataResult <T> : IResult
    {
        T Data { get; }

    }
}
