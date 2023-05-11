using HabitTracker.barlowtyler96.Controller;
using HabitTracker.barlowtyler96.View;
using System.Configuration;

namespace HabitTracker;

internal class Program
{
    private static readonly string connectionString = ConfigurationManager.AppSettings.Get("connString");
    static void Main(string[] args)
    {
        DbController.CreateTable();
        MainMenu.GetUserInput();
    }
}