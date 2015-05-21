using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void informatioBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAboutPage about = new frmAboutPage();
            about.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GameState.Difficulty selectedDifficulty = GameState.Difficulty.Easy;
            string userName = string.IsNullOrWhiteSpace(txtUserName.Text) ? "Unknown Coder" : txtUserName.Text;
            bool useHints = checkUseHints.Checked;
            bool useCheats = checkAllowCheats.Checked;

            RadioButton[] diffButtons = { this.radioEasy, this.radioHard, this.radioMedium, this.radioInsane };

            if (!diffButtons.Any(radio => radio.Checked))
            {
                MessageBox.Show("Please select a difficulty first!");
            }
            else
            {
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
                else if (radioInsane.Checked)
                {
                    selectedDifficulty = GameState.Difficulty.Insane;
                }

                //Add the game state object to the game
                Program.theGameState = new GameState(userName, selectedDifficulty, true, true);
                frmMain theMainGame = new frmMain();

                
                theMainGame.Show();
            }



        }
    }
}
