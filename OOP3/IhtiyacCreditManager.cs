using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class IhtiyacCreditManager : ICreditManager
    {
        public void Calculate()
        {

            Console.WriteLine("Ihtiyac Kredisi Hesaplaması Yapıldı.");
        }

        public void Name()
        {
            Console.WriteLine("İhtiyac Kredisi");
        }
    }
}
