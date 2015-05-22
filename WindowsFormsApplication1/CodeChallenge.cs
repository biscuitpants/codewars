using Microsoft.CSharp;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;

namespace WindowsFormsApplication1
{
    /// <summary>
    ///     Code challenge class
    ///
    ///     Holds a code challenge
    /// </summary>

    public class CodeChallenge
    {
        public CodeChallenge(string challenge, string answer, string hint, string output, int time, int timeScore)
        {
            challengeText = challenge;
            challengeAnswer = answer;
            challengeHint = hint;
            expectedOutput = output;
            challengeTime = time;
            challengeScore = timeScore;
        }

        private string challengeText;
        private string expectedOutput;
        private string challengeHint;
        private string challengeAnswer;
        private int challengeTime;
        private int challengeScore;
        private int challengeFactor;

        public string ExpectedOutput
        {
            get { return expectedOutput; }
            set { expectedOutput = value; }
        }

        public int ChallengeFactor
        {
            get { return challengeFactor; }
            set { challengeFactor = value; }
        }

        public string ChallengeText
        {
            get { return challengeText; }
            set { challengeText = value; }
        }

        public string ChallengeAnswer
        {
            get { return challengeAnswer; }
            set { challengeAnswer = value; }
        }

        public string ChallengeHint
        {
            get { return challengeHint; }
            set { challengeHint = value; }
        }

        public int ChallengeTime
        {
            get { return challengeTime; }
            set { challengeTime = value; }
        }

        /// <summary>
        ///     Checks the code challenge against an input
        ///
        ///     Checks the users input against a code challenge. Uses the C# Code Provider class to compile and run the code
        ///     Returns a CompileResult object, which holds errors and output text
        /// </summary>
        /// <param name="input">The users inputted code</param>
        /// <returns>CompileResult object</returns>

        //Check the time of this, timout of 60 seconds maybe

        public RunResult checkChallengeAgainstUserInput(string input)
        {
            RunResult theResult = new RunResult();

            /*
             * Two parts of the source code
             * The first part is the namespace and the class, with a generic method
             * Second part is what the end bit of the program, which closes the braces
            */
            string sourceCodePartOne =
                @"

                using System;

                namespace Challenge
                {
                    public class CodeTest
                    {
                        public string TestThisCode()
                        {
                            string aString;
                           ";

            string sourceCodePartTwo = @"
                            return aString;
                        }
                    }
                }
            ";

            string final = sourceCodePartOne + input + sourceCodePartTwo;

            Dictionary<string, string> providerOptions = new Dictionary<string, string>
                {
                    {"CompilerVersion", "v3.5"}
                };
            CSharpCodeProvider provider = new CSharpCodeProvider(providerOptions);

            CompilerParameters compilerParams = new CompilerParameters
            {
                GenerateInMemory = true,
                GenerateExecutable = false
            };

            CompilerResults results = provider.CompileAssemblyFromSource(compilerParams, final);

            //Print the results of the compile
            foreach (string s in results.Output)
            {
                Debug.WriteLine(s);
            }

            if (results.Errors.Count != 0)
            {
                string error = "";
                foreach (var st in results.Errors)
                {
                    error = error + st;
                }

                //throw new Exception(error);
                theResult = new RunResult(true, error);
            }

            if (!theResult.HasErrors)
            {
                object o = results.CompiledAssembly.CreateInstance("Challenge.CodeTest");
                MethodInfo mi = o.GetType().GetMethod("TestThisCode");

                //Write to debug the output of the method

                theResult.OutputText = (string)mi.Invoke(o, null);

                Debug.WriteLine(theResult.OutputText);
            }

            return theResult;
        }
    }
}