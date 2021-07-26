using System;
using System.IO;
using System.Linq;

namespace DMARC_parser
{
    class Program
    {
         static void Main(string[] args)
        {
            xml_parser parser;
            string path;

            if (args.Any())
            {
                path = args[0];
                if (File.Exists(path))
                {
                    parser = new xml_parser(path);
                    return;
                }
                while(!File.Exists(path))
                {
                    pl("File " + path + "not found...");
                    pl("Insert valid filepath...");
                    path = rl();
                }
                parser = new xml_parser(path);
                return;
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
