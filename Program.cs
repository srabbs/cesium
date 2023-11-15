using System;
using System.IO;

class Program
{
    static void Main()
    {
        AllFunctions();

        // code goes after the AllFunctions function and before the StayOn function

        StayOn();
    }

    private static void StayOn() // keeps the program on until you close it manually
    {
        bool appOpen = true;
        
        while (appOpen == true)
        {
            Console.ReadLine();
        }
    }

    private static void SaveCode() // saves your code
    {
        
    }

    private static void Tab() // tab
    {
        if (Console.ReadKey().Key == ConsoleKey.Tab)
        {
            Console.Write("    ");
        }
    }

    private static void Lines() // saves all the lines as strings
    {

    }

    private static void AllFunctions() // calls every function to keep the Main function more organized
    {
        Tab();
        Lines();
    }

}