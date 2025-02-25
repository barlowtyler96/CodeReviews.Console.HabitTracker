﻿using HabitTracker.barlowtyler96.Controller;
namespace HabitTracker.barlowtyler96.View;

internal class MainMenu
{
    public static void GetUserInput()
    {

        Console.Clear();
        var closeApp = false;
        while (closeApp == false)
        {
            Console.WriteLine("\n\nMAIN MENU");
            Console.WriteLine("\nWhat would you like to do?\n");
            Console.WriteLine("================================");
            Console.WriteLine("Type 0 to Exit");
            Console.WriteLine("Type 1 to View Records");
            Console.WriteLine("Type 2 to Insert a Record");
            Console.WriteLine("Type 3 to Delete a Record");
            Console.WriteLine("Type 4 to Update a Record");
            Console.WriteLine("================================\n");

            var commandInput = Console.ReadLine();

            switch (commandInput.Trim())
            {
                case "0":
                    Console.WriteLine("\nGoodbye!");
                    closeApp = true;
                    break;

                case "1":
                    DbController.ViewRecords();
                    break;

                case "2":
                    DbController.Insert();
                    break;

                case "3":
                    DbController.Delete();
                    break;

                case "4":
                    DbController.Update();
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("Invalid input. Review the menu and enter a valid command.");
                    break;
            }
        }
    }
}