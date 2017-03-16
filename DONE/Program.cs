using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace SimpleChromepwrec
{
    /*
     <~> Simple module that shows locally stored passwords and cookies in Google Chrome
     <~> No external DDLs or other dependencies needed. SQLiteHandler and other classes are already here :--)
    
         */
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var kek in Chrome.GetSavedPasswords())
            {
                Console.WriteLine("SITE: " + kek.URL);
                Console.WriteLine("USER: " + kek.Username);
                Console.WriteLine("PASSWORD: " + kek.Password);
                Console.WriteLine(Environment.NewLine);

            }
            Console.ReadKey();

        }
    }

   
}
