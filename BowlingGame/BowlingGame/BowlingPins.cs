using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGame
{
    public class BowlingPins
    {
        public BowlingPins() { }
        public void DisplayBowlingPins()
        {
            
            // Loop through 4 rows.
            for (int i = 4; i >= 1; i--)
            {
                CenterPins(i);
                // Loop through the number of columns in the current row.
                for (int j = 1; j <= i; j++)
                {
                    // Print a "bowling pin" character for each column.
                    Console.Write(" O");
                }
                // Move to the next line after each row.
                Console.WriteLine();
            }
        }

        private void CenterPins(int i)
        {
            // Calculate the number of spaces to insert before the first pin on the current row.
            int numSpaces = (Console.WindowWidth / 2) - i;

            // Insert the spaces before the first pin on the current row.
            for (int k = 0; k < numSpaces; k++)
            {
                Console.Write(" ");
            }
        }

    }
}
