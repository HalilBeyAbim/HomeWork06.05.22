using System;
using System.Collections.Generic;
using System.Text;

namespace MainPrintFile
{
    class PDF : Iprintable
    {
        public void Print()
        {
           Console.WriteLine("Print PDF ");
        }
    }
}
