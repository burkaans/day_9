﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_9
{
    class Program
    {
        static void Main(string[] args)
        {

            Test TestaObjekts = new Test();
            int rezultats = TestaObjekts.Saskaitisana(7, 3);

            Test TestaObjekts2 = new Test();

            TestaObjekts.skaitlis = 3;
            TestaObjekts2.skaitlis = 6;
            Console.WriteLine("izvade teksta objeks: " + TestaObjekts.skaitlis);
            Console.WriteLine("izvade teksta objekts: " + TestaObjekts2.skaitlis);
            Console.WriteLine("izvade no klases: " +rezultats);
            Console.ReadLine();
        }
    }
}
