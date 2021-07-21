using System;
using System.IO;
using System.Threading.Tasks;

namespace DMARC_parser
{
    class Program
    {
         static void Main(string[] args)
        {
            pl("Insert filename");
            var filename = rl();

            //verify that file exists
            while(!File.Exists(filename))
            {
                pl("File not found , try again");
                filename = rl();
            }

        }


        /// <summary>
        /// Just a function to print to console..
        /// </summary>
        /// <param name="txt">What to print</param>
        private static void pl(string txt)
        {
            Console.WriteLine(txt);
        }

        /// <summary>
        /// Just a function to read the console
        /// </summary>
        /// <returns>The input</returns>
        private static string rl()
        {
            return Console.ReadLine();
        }
    }
}
