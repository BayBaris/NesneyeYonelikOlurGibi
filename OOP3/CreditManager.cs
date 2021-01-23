using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //Okunurluğu artırmak için interfaceler I ile başlatılır...
    //Şablonumuz...
    //Genellikle operasyonel işlemlerde kullanılır... (Interface)
    //Birbirinin Alternatifi olan ancak yapması gereken işleri farklı olan classlarla birlikte kullanılır.
    interface ICreditManager
    {
        void Calculate();
        void DoIt();
    }
}
