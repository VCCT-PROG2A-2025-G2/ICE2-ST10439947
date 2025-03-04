//==============================================================================/
/*
 * Amelia Swart
 * ST10439947
 * Hello World Project
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
//---------------------------------------------------------------------------------/
// This is the namespace for the project
namespace ICE2
{
    //---------------------------------------------------------------------------------/
    // This is the main class for the project
    class Program
    {
        //---------------------------------------------------------------------------------/
        // This is the main method for the project
        static void Main(string[] args)
        {
            //This creates a new instance of the SoundsClass
            SoundsClass sounds = new SoundsClass();
            //This calls the SoundMenu method from the SoundsClass
            sounds.SoundMenu();
        }
    }
}
//==================================================================================/