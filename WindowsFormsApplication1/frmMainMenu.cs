using System;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        //When the user clicks on the about item in the menu, do the following
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Create a new frmAboutPage
            frmAboutPage about = new frmAboutPage();
            //Show the about page
            about.Show();
        }

        //When the user clicks the btnStartGame, do the following
        private void button1_Click(object sender, EventArgs e)
        {
            //Create a difficulty variable
            GameState.Difficulty selectedDifficulty = GameState.Difficulty.Easy;
            //Get the users name
            //If the text box is empty then default their name to 'Unknown Coder'
            string userName = string.IsNullOrWhiteSpace(txtUserName.Text) ? "Unknown Coder" : txtUserName.Text;
            //Get the checked state of the Show Hints and Allow round skips check boxes
            bool useHints = checkUseHints.Checked;
            bool useRoundSkips = checkAllowSkipRounds.Checked;
            bool infinteTime = cbxInfiniteTime.Checked;

            //Create an array of all the difficulty buttons
            RadioButton[] diffButtons = { this.radioEasy, this.radioHard, this.radioMedium };

            //Check if any of the radio buttons are not checked
            if (!diffButtons.Any(radio => radio.Checked))
            {
                MessageBox.Show("Please select a difficulty first!");
            }
            //Else if they are checked, continue
            else
            {
                //Check which one is checked and set the games difficulty to the corresponding radio button
                if (radioEasy.Checked)
                {
                    selectedDifficulty = GameState.Difficulty.Easy;
                }
                else if (radioMedium.Checked)
                {
                    selectedDifficulty = GameState.Difficulty.Medium;
                }
                else if (radioHard.Checked)
                {
                    selectedDifficulty = GameState.Difficulty.Hard;
                }

                //Create a new GameState object and set it to the Program game state
                //Set to program game state as its globally visible to all other classes
                Program.theGameState = new GameState(userName, selectedDifficulty, useHints, useRoundSkips, infinteTime);
                this.Hide();

                //Create the frmGame which is the game form
                frmGame theMainGame = new frmGame();

                //Show the game form
                theMainGame.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
        }

        private void informatioBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCodeResources codeRes = new frmCodeResources();
            codeRes.Show();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkAllowCheats_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            frmCodeResources codeResForm = new frmCodeResources();
            codeResForm.Show();
        }
    }
}