using System;

namespace DMARC_parser
{
    class Program
    {
         static void Main(string[] args)
        {
            var path = "C:\\test.xml";

            xml_parser parser = new xml_parser(path);
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
