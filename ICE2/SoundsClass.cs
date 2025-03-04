//==============================================================================
/*
 * Amelia Swart
 * ST10439947
 * Hello World Project
 */
using System;
using System.Collections.Generic;
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
                    Console.WriteLine("1. OIIAI");
                }

                if (checkSound2 == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("2. Meow Meow Meow Meow");
                }
                else
                {
                    Console.WriteLine("2. Meow Meow Meow Meow");
                }
                
                if (checkSound3 == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("3. Sus guy");
                }
                else
                {
                    Console.WriteLine("3. Sus guy");
                }

                Console.WriteLine("Press Q to quit");

                //This reads the user's input
                var key = Console.ReadKey();

                //This plays the sound based on the user's input and changes the color of related the menu option
                switch (key.Key)
                {
                    case ConsoleKey.D1:
                        SoundPlayer soundPlayer = new SoundPlayer(@"C:\Users\Amelia\source\repos\ICE2\ICE2\oiiai.wav");
                        soundPlayer.Play();
                        checkSound1 = 1;
                        break;

                    case ConsoleKey.D2:
                        SoundPlayer soundPlayer2 = new SoundPlayer(@"C:\Users\Amelia\source\repos\ICE2\ICE2\meow.wav");
                        soundPlayer2.Play();
                        checkSound2 = 1;
                        break;
                    case ConsoleKey.D3:
                        SoundPlayer soundPlayer3 = new SoundPlayer(@"C:\Users\Amelia\source\repos\ICE2\ICE2\susguy.wav");
                        soundPlayer3.Play();
                        checkSound3 = 1;
                        break;
                    case ConsoleKey.Q:
                        QuitApp();
                        return;
                }

                Console.Clear();
            }
        }

        private void QuitApp()
        {
            System.Environment.Exit(0);
        }
        

    }
}
