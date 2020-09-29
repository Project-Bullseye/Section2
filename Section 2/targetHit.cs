using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_2
{
    public class targetHit
    {
        //this will be for saving scores and printing them
        public static void ScoreKeep()
        {
            string path = "C:\\Users\\Public\\Documents\\myData.txt";
            int temp = 100;


            if (temp < 1000)
            {
                Console.WriteLine($"You won in {temp} seconds!!!!!!");
                Process.Start("Chrome.exe", "https://www.youtube.com/watch?v=mnpjpdhUNjY");
                Console.ReadLine();

            } 
            else
            {
                Console.WriteLine($"You couldn’t hit the broad side of a barn with a bowling ball. Maybe try again.");
                Process.Start("Chrome.exe", "https://www.youtube.com/watch?v=dQw4w9WgXcQ");
                Console.ReadLine();
            }
            
        }
    }
}
