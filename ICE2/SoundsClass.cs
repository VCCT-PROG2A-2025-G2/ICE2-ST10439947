//==============================================================================
/*
 * Amelia Swart
 * ST10439947
 * Hello World Project
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
//---------------------------------------------------------------------------------/
// This is the namespace for the project
namespace ICE2
{
    //---------------------------------------------------------------------------------/
    // This is the class for the project
    class SoundsClass
    {
        //---------------------------------------------------------------------------------/
        // This is the main method for the project
        public void SoundMenu()
        {
            //these are the variables that check if the sound has been played before
            int checkSound1 = 0;
            int checkSound2 = 0;
            int checkSound3 = 0;

            //these are the file paths for the sounds
            string sound1FilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Sounds", "oiiai.wav");
            string sound2FilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Sounds", "meow.wav");
            string sound3FilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Sounds", "susguy.wav");

            //This loops the menu until the user quits
            while (true)
            {
                //This welcomes the user to the program
                Console.WriteLine("Welcome to The Program! :3\n");
                Console.WriteLine("Please select a sound to play:");

                //This displays the menu options and changes the color of the menu option based on if the sound has been played before
                if (checkSound1 == 1) {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("1. OIIAI");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("1. OIIAI");
                }
                //  this checks if the sound has been played before and changes the color of the menu option
                if (checkSound2 == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("2. Meow Meow Meow Meow");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("2. Meow Meow Meow Meow");
                }
                //this checks if the sound has been played before and changes the color of the menu option
                if (checkSound3 == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("3. Sus guy");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("3. Sus guy");
                }
                //this resets the color of the menu option and displays the quit option
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Press Q to quit\n");

                //This reads the user's input
                var key = Console.ReadKey();

                //This plays the sound based on the user's input and changes the color of related the menu option
                switch (key.Key)
                {
                    //This plays the first sound
                    case ConsoleKey.D1:
                        Console.WriteLine($"\n\nFile is located at {sound1FilePath} \n");
                        //This is the ascii art for the sound
                        Console.WriteLine(" /\\_/\\  \r\n( - w - )  \r\n(  --  )~\u2665\r\n");
                        SoundPlayer player1 = new SoundPlayer(sound1FilePath);
                        player1.PlaySync();
                        checkSound1 = 1;
                        break;
                    //This plays the second sound
                    case ConsoleKey.D2:
                        Console.WriteLine($"\n\nFile is located at {sound2FilePath}\n");
                        Console.WriteLine(" /\\_/\\  \r\n( o.o )  \r\n > ^ <  \r\n");
                        SoundPlayer player2 = new SoundPlayer(sound2FilePath);
                        player2.PlaySync();
                        checkSound2 = 1;
                        break;
                    //This plays the third sound
                    case ConsoleKey.D3:
                        Console.WriteLine($"\n\nFile is located at {sound3FilePath}\n");
                        Console.WriteLine(" _._     _,-'\"\"`-._\r\n(,-.`._,'(       |\\`-/|\r\n    `-.-' \\ )-`( , o o)\r\n          `-    \\`_`\"'-");
                        SoundPlayer player3 = new SoundPlayer(sound3FilePath);
                        player3.PlaySync();
                        checkSound3 = 1;
                        break;
                    //This quits the program
                    case ConsoleKey.Q:
                        //This is the quit message
                        QuitApp();
                        return;
                }
                //This clears the console and resets the color
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
            }
        }
        //---------------------------------------------------------------------------------/
        // This is the method that quits the program
        private void QuitApp()
        {
            //this clears the console and displays the quit message in red
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\nThis program has ended. Good bye :3");
            Console.ForegroundColor = ConsoleColor.White;
            System.Environment.Exit(0);
        }
        

    }
}
