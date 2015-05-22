namespace WindowsFormsApplication1
{
    public class RunResult
    {
        private bool hasErrors;
        private string errorText;
        private string outputText;

        public RunResult()
        {
            //Default constructor
        }

        public RunResult(bool error, string errors, string outputText)
        {
            this.hasErrors = error;
            this.errorText = errors;
            this.outputText = outputText;
        }

        public RunResult(bool error, string errors)
        {
            this.hasErrors = error;
            this.errorText = errors;
        }

        public bool HasErrors
        {
            get { return hasErrors; }
            set { hasErrors = value; }
        }

        public string ErrorText
        {
            get { return errorText; }
            set { errorText = value; }
        }

        public string OutputText
        {
            get { return outputText; }
            set { outputText = value; }
        }
    }
}