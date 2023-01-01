namespace MyAssignment
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ///handles exceptions in the windows forms
            Application.ThreadException += new ThreadExceptionEventHandler(GlobalExceptions.GlobalThreadExceptionEventHandler);
            Application.ThreadException += new ThreadExceptionEventHandler(GlobalExceptions.InvalidParameterExceptionHandler);
            Application.ThreadException += new ThreadExceptionEventHandler(GlobalExceptions.MissingParameterExceptionshandler);
            Application.ThreadException += new ThreadExceptionEventHandler(GlobalExceptions.InvalidMethodDefinitionException);
            Application.ThreadException += new ThreadExceptionEventHandler(GlobalExceptions.ValueOutOfRangeExceptionHandler);

            //this handles other exceptions
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(GlobalExceptions.UnhandledExceptionEventHandler);

            //catch all exceptions rather than throw them
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);


            Application.Run(new Form1());

        }
    }
}