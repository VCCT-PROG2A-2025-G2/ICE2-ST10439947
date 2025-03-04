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
            int checkSound1 = 0;
            int checkSound2 = 0;
            int checkSound3 = 0;

            string sound1FilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Sounds", "oiiai.wav");
            string sound2FilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Sounds", "meow.wav");
            string sound3FilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Sounds", "susguy.wav");

            //This loops the menu until the user quits
            while (true)
            {
                //This welcomes the user to the program
                Console.WriteLine("Welcome to The Program! :3");
                Console.WriteLine("Please select a sound to play:");

                //these check if the sound has been played before and changes the color of the menu option
                if (checkSound1 == 1) {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("1. OIIAI");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("1. OIIAI");
                }

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

                Console.WriteLine("Press Q to quit");

                //This reads the user's input
                var key = Console.ReadKey();

                //This plays the sound based on the user's input and changes the color of related the menu option
                switch (key.Key)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine($"\nFile is located at {sound1FilePath}");
                        SoundPlayer player1 = new SoundPlayer(sound1FilePath);
                        player1.PlaySync();
                        checkSound1 = 1;
                        break;

                    case ConsoleKey.D2:
                        Console.WriteLine($"\nFile is located at {sound2FilePath}");
                        SoundPlayer player2 = new SoundPlayer(sound2FilePath);
                        player2.PlaySync();
                        checkSound2 = 1;
                        break;
                    case ConsoleKey.D3:
                        Console.WriteLine($"\nFile is located at {sound3FilePath}");
                        SoundPlayer player3 = new SoundPlayer(sound3FilePath);
                        player3.PlaySync();
                        checkSound3 = 1;
                        break;
                    case ConsoleKey.Q:
                        QuitApp();
                        return;
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
            }
        }

        private void QuitApp()
        {
            System.Environment.Exit(0);
        }
        

    }
}
