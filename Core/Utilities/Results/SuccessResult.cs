using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessResult : Result
    {
        // base : bir üst classa true ve messages gönderdik.
        // yani diger tarafta sadece messages verebiliriz.

        // : base(true) : gonderdigimiz zaman bir ust sınıftaki tek parametre olan çalışacak.
        // yani true yu default olarak vermiş olduk.
        public SuccessResult(string messages):base(true,messages)
        {

        }

        public SuccessResult() : base(true)
        {

        }
    }
}
