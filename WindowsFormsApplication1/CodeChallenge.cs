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
        //Variables the class will use
        private string challengeAnswer;

        private int challengeFactor;
        private string challengeHint;
        private int challengeScore;
        private string challengeText;
        private int challengeTime;
        private string expectedOutput;

        public CodeChallenge(string challenge, string answer, string hint, string output, int time, int timeScore)
        {
            challengeText = challenge;
            challengeAnswer = answer;
            challengeHint = hint;
            expectedOutput = output;
            challengeTime = time;
            challengeScore = timeScore;
        }

        public string ChallengeAnswer
        {
            get { return challengeAnswer; }
            set { challengeAnswer = value; }
        }

        public int ChallengeFactor
        {
            get { return challengeFactor; }
            set { challengeFactor = value; }
        }

        public string ChallengeHint
        {
            get { return challengeHint; }
            set { challengeHint = value; }
        }

        public string ChallengeText
        {
            get { return challengeText; }
            set { challengeText = value; }
        }

        public int ChallengeTime
        {
            get { return challengeTime; }
            set { challengeTime = value; }
        }

        public string ExpectedOutput
        {
            get { return expectedOutput; }
            set { expectedOutput = value; }
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

            //Setup the options for the compiler
            //Give it a version
            Dictionary<string, string> providerOptions = new Dictionary<string, string>
                {
                    {"CompilerVersion", "v3.5"}
                };
            CSharpCodeProvider provider = new CSharpCodeProvider(providerOptions);

            //Setup the compiler parameters
            //Generate in memory is equal to true so that its compiled on the fly and avaliable during the program duration
            //Generate executable is equal to false so that an undeeded executable is not created on compile
            CompilerParameters compilerParams = new CompilerParameters
            {
                GenerateInMemory = true,
                GenerateExecutable = false
            };

            //Get the result set of the compile and create a CompilerResults object
            CompilerResults results = provider.CompileAssemblyFromSource(compilerParams, final);

            //Print the results of the compile
            foreach (string s in results.Output)
            {
                Debug.WriteLine(s);
            }

            //If we have errors from the compile we need to add them to our RunResult object
            if (results.Errors.Count != 0)
            {
                string error = "";
                foreach (var st in results.Errors)
                {
                    error = error + st;
                }

                //Create a new RunResult object and add the errors to it
                //The first argument means that the compile has errors
                theResult = new RunResult(true, error);
            }

            //If our compile result does not have errors then run the code
            if (!theResult.HasErrors)
            {
                //Create a generic object which contains an instance of the Class 'CodeTest'
                //A generic object is used since the class could be any type
                object o = results.CompiledAssembly.CreateInstance("Challenge.CodeTest");
                //Get the info of the method (ie the method body) and create a MethodInfo object
                MethodInfo mi = o.GetType().GetMethod("TestThisCode");

                //Write to debug the output of the method

                //Invoke the method and set the output of it to the OutputText of the RunResult object
                theResult.OutputText = (string)mi.Invoke(o, null);

                Debug.WriteLine(theResult.OutputText);
            }

            //Return the RunResult object
            return theResult;
        }
    }
}