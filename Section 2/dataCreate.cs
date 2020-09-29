using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace Section_2
{
    class dataCreate
    {
        //checking if the folder and file and already there and if not creating them
        public static void FolderCreateCheck()
        {
            string path = "C:\\Users\\Public\\Documents\\myData.txt";

            if (!File.Exists(path))
            {
                // Create the file if not already made.
                using (FileStream fs = File.Create(path))
                {
                    //puts text in it
                    Byte[] info =
                   new UTF8Encoding(true).GetBytes("This is where we will keep the score \n");

                    fs.Write(info, 0, info.Length);
                    fs.Close();
                }
            }
            else
            {
                //writes in file for test
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine("This is where we will keep the score 2 \n");
                    sw.Close();
                }
            }
        }
    }
}
