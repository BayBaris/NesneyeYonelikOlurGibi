using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class HouseCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Konut Kredisi Hesaplaması Yapıldı.");
        }

        public void DoIt()
        {
            throw new NotImplementedException();
        }
    }
}
