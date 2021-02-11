using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        // Getter edilen propertiler Constructor içinde setter edilebilir. ayrıyeten bir setter oluşturmaya gerek yok.
        // Kodların okunurlugunu standartize ediyoruz karşı taraftan setterına ulaşmamaları için.
        // this(success) : bu constructorda hem kendimizi tekrarı onledik hemde 12 satır çalıştıgında otomatıkmen 20.satırıda çalıstırmış
        // oluyoruz.
        public Result(bool success, string messages):this(success)  // bu 20.satırdaki kod da çalışacak 2 parametre gonderirsek.
        {
          
            Messages = messages;
            
        }


        public Result(bool success)
        {
            Success = success;
        }

        public bool Success { get; }

        public string Messages { get; }
    }
}
