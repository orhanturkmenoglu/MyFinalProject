using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
  public  class ErrorResult :Result
    {
        // hata oldgunda burdan donderiyoruz success resultun aynısı .
        // işlem sonucu başarısız ise burdan göndermiş olduk
        public ErrorResult(string messages) : base(false,messages)
        {

        }

        public ErrorResult() : base(false)
        {

        }
    }
}
