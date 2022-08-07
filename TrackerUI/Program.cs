namespace TrackerUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Initialize the database connections.
            TrackerLibrary.GlobalConfig.InitializesConnections(true, true);

            //Application.Run(new TournamentDashboardForm());

            Application.Run(new CreatePrizeForm());
        }
    }
}