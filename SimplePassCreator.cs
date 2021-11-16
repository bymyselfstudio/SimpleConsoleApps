using System;
using System.Collections.Generic;

namespace SimplePassCreator
{
    // Probably not the smartest solution,
    // but it works fine for me ;)
    class Program
    {
        static void Main()
        {
            Random rnd = new Random();

            List<char> passkey = new List<char>
            {
                //Numbers
                '1', '2', '3', '4', '5', '6',
                '7', '8', '9', '0',

                //Lowercase letters
                'a', 'b', 'c', 'd', 'e', 'f',
                'g', 'h', 'i', 'j', 'k', 'l',
                'm', 'n', 'o', 'p', 'q', 'r',
                's', 't', 'u', 'v', 'w', 'x',
                'y', 'z',

                //Uppercase letters
                'A', 'B', 'C', 'D', 'E', 'F',
                'G', 'H', 'I', 'J', 'K', 'L',
                'M', 'N', 'O', 'P', 'Q', 'R',
                'S', 'T', 'U', 'V', 'W', 'X',
                'Y', 'Z',

                //Special characters
                '!', '%', '+', '?', '$', '&'
                //'_', '~', '/'  , '[', ']', '(', ')'
            };

            Console.WriteLine
            ("Input password length as an int" +
            "number:\n(MaxLength = {0})\n\t",
            passkey.Count);

            int num = Convert.ToInt32(Console.ReadLine());

            while (true)
            {
                for (int i = 0; i < num; i++)
                {
                    int index =
                    rnd.Next(passkey.Count);
                    Console.Write(passkey[index]);
                }

                Console.WriteLine();
                Console.ReadKey();
            }  
        }
    }
}
