using System.IO;

namespace WindowsFormsApplication1
{
    /// <summary>
    ///     Game state
    ///
    ///     Holds the game state variables
    /// </summary>
    public class GameState
    {
        //Constants that the class needs
        private const int EASY_OFFSET = 0;

        private const string FILE_NAME = "ch_";
        private const int HARD_OFFSET = 4;
        private const int MEDIUM_OFFSET = 2;
        private const int NUM_OF_CHALLENGES = 6;

        //Variables that the class uses
        private static CodeChallenge[] allChallenges;

        private static Difficulty game_userDifficulty;
        private bool game_allowHints;
        private int game_currentRound;
        private int game_currentTimeLeft;
        private bool game_allowRoundSkips;
        private string game_userName;
        private int game_userScore;
        private bool game_infiniteTimeMode;

        //Default constructor
        public GameState()
        {
            //Loads the challenge files for information (not game use)
            LoadChallengeFilesForInformation();
        }

        /// <summary>
        /// Game State constructor
        ///
        /// Takes in the difficulty, if hints are used, if skips are allowed, and infinite time mode
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="userDifficulty"></param>
        /// <param name="hints"></param>
        /// <param name="skips"></param>
        /// <param name="infinite"></param>
        public GameState(string userName, Difficulty userDifficulty, bool hints, bool skips, bool infinite)
        {
            //Switch through the users difficulty choice to see what the starting round is
            switch (userDifficulty)
            {
                case Difficulty.Easy:
                    game_currentRound = 0;
                    break;

                case Difficulty.Medium:
                    game_currentRound = 2;
                    break;

                case Difficulty.Hard:
                    game_currentRound = 4;
                    break;
            }

            //Set up game variables using the users input
            game_userScore = 0;
            game_userName = userName;
            game_userDifficulty = userDifficulty;
            game_allowRoundSkips = skips;
            game_allowHints = hints;
            game_infiniteTimeMode = infinite;

            //Load our challenge files (for game use)
            LoadChallengeFiles();
        }

        //Enumerator for difficulty
        public enum Difficulty
        {
            Easy,
            Medium,
            Hard,
            Insane
        };

        public CodeChallenge[] AllChallenges
        {
            get { return allChallenges; }
            set { allChallenges = value; }
        }

        public int Game_currentRound
        {
            get { return game_currentRound; }
            set { game_currentRound = value; }
        }

        public bool Game_infiniteTimeMode
        {
            get { return game_infiniteTimeMode; }
            set { game_infiniteTimeMode = value; }
        }

        public int Game_currentTimeLeft
        {
            get { return game_currentTimeLeft; }
            set { game_currentTimeLeft = value; }
        }

        public bool Game_allowRoundSkips
        {
            get { return game_allowRoundSkips; }
            set { game_allowRoundSkips = value; }
        }

        public bool Game_UseHints
        {
            get { return game_allowHints; }
            set { game_allowHints = value; }
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

        public int Game_userScore
        {
            get { return game_userScore; }
            set { game_userScore = value; }
        }

        /// <summary>
        /// Loads challenge files
        ///
        /// Loads the challenge files used in the game
        /// </summary>
        public static void LoadChallengeFiles()
        {
            //The user start level set to zero
            int userStartLevel = 0;

            //Switch through the users difficulty to figure out the offset for files
            //The files naming goes ch_0 ch_1 etc
            //Each number presents the round number
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
            }

            //Work out the length for the challenges array
            int length = NUM_OF_CHALLENGES - userStartLevel;
            int fileStart = userStartLevel;

            //Default of 5
            allChallenges = new CodeChallenge[NUM_OF_CHALLENGES];

            //For each of the challenge files do the following
            for (int i = fileStart; i < allChallenges.Length; i++)
            {
                //Open up the challenge file
                StreamReader streamReader = new StreamReader("Challenges/" + FILE_NAME + i + ".txt");
                //Read the text
                string text = streamReader.ReadToEnd();
                //Split it into parts
                string[] parts = text.Split('@');

                //Create a code challenge with input from the challenge file
                CodeChallenge newChallenge = new CodeChallenge(parts[0], parts[1], parts[2], parts[3], int.Parse(parts[4]), int.Parse(parts[5]));

                //Set the new challenge
                allChallenges[i] = newChallenge;

                //Close the reader
                streamReader.Close();
            }
        }

        /// <summary>
        /// Load Challenge Files for Information
        ///
        /// Loads the challenge files purely for information use
        /// Not different from the above method (LoadCHallengeFiles) except it does not use the users input / settings
        /// </summary>
        public static void LoadChallengeFilesForInformation()
        {
            //Default of 5
            allChallenges = new CodeChallenge[NUM_OF_CHALLENGES];

            for (int i = 0; i < allChallenges.Length; i++)
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

        /// <summary>
        /// Next Round
        ///
        /// Starts the next round
        /// </summary>
        public void NextRound()
        {
            Game_currentRound++;
        }
    }
}