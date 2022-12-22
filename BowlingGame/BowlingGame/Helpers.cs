using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGame
{
    static class Helpers
    {
        public static void InsertWriteLines(int numWriteLines)
        {
            for (int i = 0; i < numWriteLines; i++)
            {
                Console.WriteLine();
            }
            
        }
    }
}
