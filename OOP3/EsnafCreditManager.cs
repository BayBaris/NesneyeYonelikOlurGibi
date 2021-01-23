using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class EsnafCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Esnaf Kredisi Hesaplaması Yapıldı");
        }

        public void DoIt()
        {
            throw new NotImplementedException();
        }
    }
}
