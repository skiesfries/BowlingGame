using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGame
{
    public class Game
    {
        private BowlingPins pins = new BowlingPins();
        private Scoreboard scoreboard= new Scoreboard();

        public Game() { }

        public void DisplayGameElements()
        {
            scoreboard.DisplayScoreboard();
            Helpers.InsertWriteLines(2);
            pins.DisplayBowlingPins();
           
           
        }
    }
}
