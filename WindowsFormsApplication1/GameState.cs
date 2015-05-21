using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    /// <summary>
    ///     Game state
    ///     
    ///     Holds the game state variables
    /// </summary>
    public class GameState
    {

        frmMain theGameForm;

        private int game_currentRound;
        private int game_userScore;
        private string game_userName;
        private bool game_useCheats;
        private bool game_allowHints;
        private static Difficulty game_userDifficulty;
        private static CodeChallenge[] allChallenges;
        private int game_currentTimeLeft;

        const int EASY_OFFSET = 1;
        const int MEDIUM_OFFSET = 4;
        const int HARD_OFFSET = 7;
        const int INSANE_OFFSET = 10;
        const string FILE_NAME = "ch_";

        public GameState()
        { 
        
        }

        public GameState(string userName, Difficulty userDifficulty, bool hints, bool cheats)
        {
            game_currentRound = 0;
            game_userScore = 0;
            game_userName = userName;
            game_userDifficulty = userDifficulty;

            LoadChallengeFiles();
        }

        public enum Difficulty
        {
            Easy,
            Medium,
            Hard,
            Insane
        };

        public static void LoadChallengeFiles()
        {
            int userStartLevel = 0;

            switch (game_userDifficulty)
            { 
                case Difficulty.Easy:
                    userStartLevel = EASY_OFFSET;
                    break;
                case Difficulty.Medium:
                    userStartLevel = MEDIUM_OFFSET;
                    break;
                case Difficulty.Hard:
                    userStartLevel = HARD_OFFSET;
                    break;
                case Difficulty.Insane:
                    userStartLevel = INSANE_OFFSET;
                    break;
            }

            int length = 12 - userStartLevel;
            int challengeCount = 0;

            //Default of 12
            allChallenges = new CodeChallenge[6];

            for (int i = 0; i <  allChallenges.Length; i++)
            {
                StreamReader streamReader = new StreamReader("Challenges/" + FILE_NAME + i + ".txt");
                string text = streamReader.ReadToEnd();
                string[] parts = text.Split('@');

                //Create a code challenge
                CodeChallenge newChallenge = new CodeChallenge(parts[0], parts[1], parts[2], parts[3], int.Parse(parts[4]), int.Parse(parts[5]));

                allChallenges[i] = newChallenge;
                //challengeCount++;

                streamReader.Close();
            }

        }

        public void NextRound()
        {
            Game_currentRound++;
        }

        public void GameOver()
        { 
            //Gameover condition
        }

        public int Game_currentTimeLeft
        {
            get { return game_currentTimeLeft; }
            set { game_currentTimeLeft = value; }
        }

        public int Game_currentRound
        {
            get { return game_currentRound; }
            set { game_currentRound = value; }
        }

        public int Game_userScore
        {
            get { return game_userScore; }
            set { game_userScore = value; }
        }

        public Difficulty Game_userDifficulty
        {
            get { return game_userDifficulty; }
            set { game_userDifficulty = value; }
        }

        public string Game_userName
        {
            get { return game_userName; }
            set { game_userName = value; }
        }

        public CodeChallenge[] AllChallenges
        {
            get { return allChallenges; }
            set { allChallenges = value; }
        }

        public bool Game_UseCheats
        {
            get { return game_useCheats; }
            set { game_useCheats = value; }
        }

        public bool Game_UseHints
        { 
            get { return game_allowHints; }
            set { game_allowHints = value; }
            
        }
                
    }
}
