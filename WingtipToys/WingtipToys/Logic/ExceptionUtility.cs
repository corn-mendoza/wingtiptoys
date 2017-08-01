using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace WingtipToys.Logic
{
    // Create our own utility for exceptions
    public sealed class ExceptionUtility
    {
        // All methods are static, so this can be private
        private ExceptionUtility()
        { }

        // Log an Exception
        public static void LogException(Exception exc, string source)
        {
            Console.WriteLine("********** {0} **********", DateTime.Now);
            if (exc.InnerException != null)
            {
                Console.Write("Inner Exception Type: ");
                Console.WriteLine(exc.InnerException.GetType().ToString());
                Console.Write("Inner Exception: ");
                Console.WriteLine(exc.InnerException.Message);
                Console.Write("Inner Source: ");
                Console.WriteLine(exc.InnerException.Source);
                if (exc.InnerException.StackTrace != null)
                {
                    Console.WriteLine("Inner Stack Trace: ");
                    Console.WriteLine(exc.InnerException.StackTrace);
                }
            }
            Console.Write("Exception Type: ");
            Console.WriteLine(exc.GetType().ToString());
            Console.WriteLine("Exception: " + exc.Message);
            Console.WriteLine("Source: " + source);
            Console.WriteLine("Stack Trace: ");
            if (exc.StackTrace != null)
            {
                Console.WriteLine(exc.StackTrace);
                Console.WriteLine();
            }

        }
    }
}