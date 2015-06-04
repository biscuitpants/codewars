using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmGameOver : Form
    {
        GameState theGame = Program.theGameState;

        public frmGameOver()
        {
            InitializeComponent();
        }

        private void frmGameOver_Load(object sender, EventArgs e)
        {
        
        }

        /// <summary>
        /// Load Game details
        /// 
        /// Loads the details of the current game
        /// Takes in the game state as input
        /// </summary>
        /// <param name="theGame"></param>
        public void LoadGameDetails(GameState theGame)
        { 
            //Create a new line string (cleaner code)
            string newLine = "\n";
            //Construct a string of the game info
            string gameDetails = "Game Details" + newLine
                + newLine
                + "Name: " + theGame.Game_userName + newLine
                + "Difficulty: " + theGame.Game_userDifficulty + newLine
                + "Use Hints: " + theGame.Game_UseHints + newLine
                + "Allow Skips: " + theGame.Game_allowRoundSkips + newLine
                + "Infinite Time: " + theGame.Game_infiniteTimeMode
                + newLine
                + "Final Round: " + theGame.Game_currentRound + newLine
                + "Final Scoree: " + theGame.Game_userScore;

            rtbGameDetails.Text = gameDetails;
        }
    }
}
