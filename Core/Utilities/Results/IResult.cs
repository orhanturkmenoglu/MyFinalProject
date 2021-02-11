using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    // Temel voidler için başlangıç : sadece işlem sonucu ve mesajı dondurmesi yeterli void oldugu için
    // amacımız api den gelen istegi dogru yonlendırmek .
    // bir interface oluşturarak hem sonucu donderecez hemde işlemler dönderebiliriz.yani birden fazla işlem tutabiliriz.
  public  interface IResult
    {
        bool Success { get; }
        string Messages { get; }
    }
}
