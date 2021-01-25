using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class VehicleCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Araç Kredisi Hesaplaması Yapıldı");
        }

        public void Name()
        {
            Console.WriteLine("Araç Kredisi");
        }
    }
}
