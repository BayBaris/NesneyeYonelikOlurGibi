﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //Method injection...
    class BasvuruManager
    {
        public void DoBasvuru(ICreditManager creditManager,ILoggerService loggerService)
        {
                       
            creditManager.Calculate();
            loggerService.Log();
        }
        public void DoCreditPreview(List<ICreditManager> credits)
        {
            Console.WriteLine("Alınabilir Krediler:");
            foreach (var credit in credits)
            {
                credit.Name();
            }
        }
    }
}
