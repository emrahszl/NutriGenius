using NutriGenius.Data.Entities.Seed;

namespace NutriGeniusForm
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
            FoodSeed.Seed();
            Application.Run(new MainMenu());
        }
    }
}