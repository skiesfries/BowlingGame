using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGame
{
    public class Scoreboard
    {
        private int[,] player1Scores = new int[10, 2];
        private int[,] player2Scores = new int[10, 2];

        public int[,] Player1Scores
        {
            get { return player1Scores; }
            set { player1Scores = value; }
        }

        public int[,] Player2Scores
        {
            get { return player2Scores; }
            set { player2Scores = value; }
        }

        public void DisplayScoreboard()
        {
            Console.SetCursorPosition(0, 0);
            // Print the header row.
            Console.WriteLine("Frame\t\t1\t\t2\t\t3\t\t4\t\t5\t\t6\t\t7\t\t8\t\t9\t\t10");

            // Print the first player's name and score columns.
            Console.Write("Player 1\t");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("\t{0}\t{1}", Player1Scores[i, 0], Player1Scores[i, 1]);
            }
            Console.WriteLine();

            // Print the second player's name and score columns.
            Console.Write("Player 2\t");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("\t{0}\t{1}", Player2Scores[i, 0], Player2Scores[i, 1]);
            }
            Console.WriteLine();
        }
        public void UpdateScoreboard(int playerNumber, int frameNumber, int scoreOfFirstRoll, int scoreOfSecondRoll)
        {
            // Create a dictionary that maps player numbers to scoreboards.
            var scoreboards = new Dictionary<int, int[,]>
            {
                 { 1, Player1Scores },
                 { 2, Player2Scores }
            };

            // Get the scoreboard for the specified player.
            var scoreboard = scoreboards[playerNumber];

            // Update the scores for the specified frame in the player's scoreboard.
            scoreboard[frameNumber, 0] = scoreOfFirstRoll;
            scoreboard[frameNumber, 1] = scoreOfSecondRoll;
        }

        public void CalculateScores()
        {
            int player1TotalScore = 0;
            int player2TotalScore = 0;

            // Calculate the total scores for player 1 and player 2.
            for (int i = 0; i < 10; i++)
            {
                // Check if the player scored a strike in the current frame.
                if (Player1Scores[i, 0] == 10)
                {
                    // Calculate the score for a strike.
                    player1TotalScore += 10 + Player1Scores[i + 1, 0] + Player1Scores[i + 1, 1];
                }
                // Check if the player scored a spare in the current frame.
                else if (Player1Scores[i, 0] + Player1Scores[i, 1] == 10)
                {
                    // Calculate the score for a spare.
                    player1TotalScore += 10 + Player1Scores[i + 1, 0];
                }
                else
                {
                    // Calculate the score for an open frame.
                    player1TotalScore += Player1Scores[i, 0] + Player1Scores[i, 1];
                }

                // Repeat the same process for player 2.
                if (Player2Scores[i, 0] == 10)
                {
                    player2TotalScore += 10 + Player2Scores[i + 1, 0] + Player2Scores[i + 1, 1];
                }
                else if (Player2Scores[i, 0] + Player2Scores[i, 1] == 10)
                {
                    player2TotalScore += 10 + Player2Scores[i + 1, 0];
                }
                else
                {
                    player2TotalScore += Player2Scores[i, 0] + Player2Scores[i, 1];
                }
            }

            // Display the total scores for player 1 and player 2.
            Console.WriteLine("Player 1: {0}", player1TotalScore);
            Console.WriteLine("Player 2: {0}", player2TotalScore);
        }



    }
}
