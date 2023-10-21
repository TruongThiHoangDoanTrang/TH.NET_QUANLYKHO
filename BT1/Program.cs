using BT1.Utils;
namespace BT1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DatabaseHelper.dbName = "test";
            DatabaseHelper.ServerName = "localhost";
            DatabaseHelper.userDb = "test";
            DatabaseHelper.password = "";
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new QLK());
        }
    }
}