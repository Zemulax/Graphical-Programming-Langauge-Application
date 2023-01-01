namespace MyAssignment
{
    /// <summary>
    /// A class that provides delegations for handling exceptions
    /// </summary>
    [Serializable]
    internal class GlobalExceptions : Exception
    {
        internal delegate void ExceptionMessageFunction(string message);
        private static ExceptionMessageFunction exceptionmessage;


        public static void SetExceptionMessageFunction(ExceptionMessageFunction function)
        {
            exceptionmessage = function;
        }

        /// <summary>
        /// this method handles exceptions in the windows form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">provides exception thread data</param>
        public static void GlobalThreadExceptionEventHandler(object sender, ThreadExceptionEventArgs e)
        {
            exceptionmessage("Something went wrong: " + e.Exception.Message);
            Form1.ErrorMessages.Add(e.Exception.Message);
        }

        /// <summary>
        /// this method handles any other exceptions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void UnhandledExceptionEventHandler(object sender, UnhandledExceptionEventArgs e)
        {
            Form1.ErrorMessages.Add("System error. Restart the application: " + e.ExceptionObject);
            Application.Exit();
        }

        /// <summary>
        /// hanl
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void InvalidParameterExceptionHandler(object sender, ThreadExceptionEventArgs e)
        {
            Form1.ErrorMessages.Add("Incorrect parameter was detected at: >> "
                + FormatsException.ErroredCommand + " <<");
        }

        /// <summary>
        /// handler for method definition synatx errors
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">the exception event</param>
        public static void InvalidMethodDefinitionException(object sender, ThreadExceptionEventArgs e)
        {
            Form1.ErrorMessages.Add("Warning! Please check that your method definition contains () >> "
                + FormatsException.ErroredCommand + " <<");
        }

        /// <summary>
        /// handler for missing parameters errors
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">exception event</param>
        public static void MissingParameterExceptionshandler(object sender, ThreadExceptionEventArgs e)
        {
            Form1.ErrorMessages.Add("Missing Parameter at command: >>"
                + FormatsException.ErroredCommand + " <<");
        }

        /// <summary>
        /// handles input exceptions induced
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">xception event</param>
        public static void ValueOutOfRangeExceptionHandler(object sender, ThreadExceptionEventArgs e)
        {
            Form1.ErrorMessages.Add("The input parameter is too large!"
                + FormatsException.ErroredCommand + " <<");
        }
    }

    /// <summary>
    /// an exception class that directky facilitates
    /// catching syntax exceptions from other classes
    /// </summary>
    public class FormatsException : Exception
    {
        private static string erroredCommand;

        private static ThreadExceptionEventArgs? threadException;
        public FormatsException(string message) : base(message)
        {
            erroredCommand = message;
        }


        /// <summary>
        /// this method will sendout invalid parameter
        /// exceptions to its handler
        /// </summary>
        /// <param name="innerException">the caught exception that occured</param>
        public static void InvalidParameterException(Exception innerException)
        {
            threadException = new(innerException);
            GlobalExceptions.InvalidParameterExceptionHandler(innerException.Message, threadException);
        }

        /// <summary>
        /// this method will sendout 
        /// InvalidMethodDefinitionException
        /// exceptions to its handler
        /// </summary>
        /// <param name="innerException">the caught exception that occured</param>
        public static void InvalidMethodDefinitionException(Exception innerException)
        {
            threadException = new(innerException);
            GlobalExceptions.InvalidMethodDefinitionException(innerException.Message, threadException);
        }

        /// <summary>
        /// this method sends out missingParameterException
        /// exception to its handler
        /// </summary>
        /// <param name="innerException">the caught exception that occured</param>
        public static void MissingParameterException(Exception innerException)
        {
            threadException = new(innerException);
            GlobalExceptions.MissingParameterExceptionshandler(innerException.Message, threadException);
        }

        /// <summary>
        /// this sends valuesOutOfrangeException
        /// exception to its handler
        /// </summary>
        /// <param name="innerException">the caught exception that occured</param>
        public static void ValueOutOfRangeException(Exception innerException)
        {
            threadException = new(innerException);
            GlobalExceptions.ValueOutOfRangeExceptionHandler(innerException.Message, threadException);
        }

        /// <summary>
        /// property for accessing a command where
        /// an exception occurred
        /// </summary>
        public static string ErroredCommand
        {
            get { return erroredCommand; }
        }
    }

}
