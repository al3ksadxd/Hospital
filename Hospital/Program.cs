using System;

class Program
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("If you want to login as doctor type doctor or if you want to login as admin type admin");

        string doctorLogin = "doctor";
        string adminLogin = "admin";

        string loginAs = "";

        bool trueS = true;


        int cursorLeft = Console.CursorLeft;
        int cursorTop = Console.CursorTop;

        while (trueS)
        {
            
            Console.Write("Your choice: ");

            loginAs = Console.ReadLine();

            if (loginAs == adminLogin || loginAs == doctorLogin)
            {
                Console.WriteLine("");
                trueS = false;
            }
            else
            {
                Console.SetCursorPosition(0, cursorTop - 1);
                Console.Write(new string(' ', Console.WindowWidth));
                Console.SetCursorPosition(0, cursorTop - 1);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please try again:");
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(0, cursorTop);
                Console.Write(new string(' ', Console.WindowWidth));
                Console.SetCursorPosition(0, cursorTop);
            }
        }//typing doctor or admin corrector

        if (loginAs == adminLogin)
        {
            Console.WriteLine("Please type username");
            Console.WriteLine("Please type password");
        }
        else if (loginAs == doctorLogin)
        {
            Console.WriteLine("Please type username");
            Console.WriteLine("Please type password");
        }
    }
}

