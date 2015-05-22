using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmMain : Form
    {
        private const string REGEX_TOKENS = "(public |double |int |break |else |switch |case |char |return |for |void |default |if |static |while )";
        private Color IDENTIFIER_COLOR = Color.YellowGreen;
        private int timeLeft = 0;

        private GameState theGame = Program.theGameState;

        public frmMain()
        {
            InitializeComponent();
            timer1.Interval = 1000;

            CodeChallenge firstChallenge = theGame.AllChallenges[theGame.Game_currentRound];

            lblPlayerName.Text = theGame.Game_userName;
            lblUserDifficulty.Text = theGame.Game_userDifficulty.ToString();
            lblTimeTicker.Text = firstChallenge.ChallengeTime + " sec";
            lblRoundCount.Text = "Round " + 0;
            lblScoreCount.Text = 0 + " points";
            rtbPlayerOneCodeBlock.Text = firstChallenge.ChallengeText;
            rtbErrorBlock.Text = firstChallenge.ChallengeHint;

            timeLeft = theGame.Game_currentTimeLeft;

            btnRunCode.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void rtbPlayerOneCodeBlock_TextChanged(object sender, EventArgs e)
        {
            setSyntaxColors((RichTextBox)sender);
        }

        private void rtbPlayerTwoCodeBlock_TextChanged(object sender, EventArgs e)
        {
            setSyntaxColors((RichTextBox)sender);
        }

        public void setSyntaxColors(RichTextBox box)
        {
            //C# Highlighting in a RichTextBox
            //http://www.c-sharpcorner.com/uploadfile/kirtan007/syntax-highlighting-in-richtextbox-using-C-Sharp/

            Regex reg = new Regex(REGEX_TOKENS);
            MatchCollection mc = reg.Matches(box.Text);
            int cursorStartPosition = box.SelectionStart;

            foreach (Match m in mc)
            {
                int wordStartIndex = m.Index;
                int wordStopIndex = m.Length;

                box.Select(wordStartIndex, wordStopIndex);
                box.SelectionColor = IDENTIFIER_COLOR;
                box.SelectionStart = cursorStartPosition;
                box.SelectionColor = Color.White;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Console.Write("");
        }

        private void rtbPlayerOneCodeBlock_KeyPress(object sender, KeyPressEventArgs e)
        {
            char key = e.KeyChar;
        }

        private void btnRunCode_Click(object sender, EventArgs e)
        {
            string codeBlockText = rtbPlayerOneCodeBlock.Text;
            string theAnswer = theGame.AllChallenges[theGame.Game_currentRound].ChallengeAnswer;
            timer1.Stop();

            //Get a result from compiling the code
            RunResult theResult = theGame.AllChallenges[theGame.Game_currentRound].checkChallengeAgainstUserInput(codeBlockText);

            if (!theResult.HasErrors)
            {
                rtbErrorBlock.Text = "Correct! Next round starting in 5 seconds...";
                timeLeft = theGame.Game_currentTimeLeft;
                theGame.NextRound();
                addPointsToScore(timeLeft);

                SetupGameRound(theGame);
            }
            else
            {
                rtbErrorBlock.Text = theResult.ErrorText;
                rtbErrorBlock.Text += "\n\n" + theGame.AllChallenges[theGame.Game_currentRound].ChallengeHint;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void addPointsToScore(int time)
        {
            //Formula for working out the user score
            //Get the current users level
            //Get the time left of the round
            //Multiplication / divition factor

            int multiply = theGame.AllChallenges[theGame.Game_currentRound].ChallengeFactor;
            int timeLeft = time;
            int answer = multiply * time;

            theGame.Game_userScore += answer;
            lblScoreCount.Text = theGame.Game_userScore + " points";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmCodeInformationDex frmCodeDex = new frmCodeInformationDex();
            frmCodeDex.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Debugging purposes

            RunResult theResult = theGame.AllChallenges[theGame.Game_currentRound].checkChallengeAgainstUserInput(rtbPlayerOneCodeBlock.Text);

            if (theResult.OutputText != theGame.AllChallenges[theGame.Game_currentRound].ExpectedOutput)
            {
                //Not correct
            }
            else
            {
                //Correct
                MessageBox.Show("Nice dude");
            }
        }

        //Stub to set up game
        public void SetupGameRound(GameState theState)
        {
            lblRoundCount.Text = "Round " + theGame.Game_currentRound.ToString();
            lblTimeTicker.Text = theGame.AllChallenges[theGame.Game_currentRound].ChallengeTime + " sec";
            rtbPlayerOneCodeBlock.Text = theGame.AllChallenges[theGame.Game_currentRound].ChallengeText;
            rtbErrorBlock.Text = theGame.AllChallenges[theGame.Game_currentRound].ChallengeHint;
            lblScoreCount.Text = theGame.Game_userScore + " points";
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (timeLeft >= 15)
            {
                lblTimeTicker.ForeColor = Color.Red;
            }

            if (timeLeft <= 0)
            {
                theGame.GameOver();
                timer1.Stop();

                MessageBox.Show("Game Over!");
            }
            else
            {
                theGame.Game_currentTimeLeft--;
                this.lblTimeTicker.Text = timeLeft + " sec";
            }
        }

        private void btnStartRound_Click(object sender, EventArgs e)
        {
            theGame.Game_currentTimeLeft = theGame.AllChallenges[theGame.Game_currentRound].ChallengeTime;
            btnRunCode.Enabled = true;
            timer1.Start();
        }

        private void btnSkipRound_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}