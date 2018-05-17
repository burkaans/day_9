using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_9
{
    class Test
    {
        //public, private
        public int skaitlis;
        public int Saskaitisana(int a, int b)
        {
            Izvade(); 
            return a + b;
        }
        private void Izvade()
        {
            Console.WriteLine("tests");
        }
    }
}
