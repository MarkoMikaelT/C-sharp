using System;

namespace CaeserCypher
{
    class Program
    {
        //public string[] alphabet = "abcdefghijklmnopqrstuvwxyz".toCharArray();
        static void Main()
        {
            Console.WriteLine("Input text to cypher");
            string text = Console.ReadLine();

            Console.WriteLine("Cypher number");
            int num = Convert.ToInt32(Console.ReadLine());

            string cipherText = Enchipher(text, num);
            Console.WriteLine(cipherText);

            string decipherText = Decipher(cipherText, num);
            Console.WriteLine(decipherText + "\n");

            Console.WriteLine("1. to cipher text \n2. to quit");
            int choose = Convert.ToInt32(Console.ReadLine());

            switch (choose)
            {
                case 1:
                    Main();
                    break;
                case 2:
                    break;
            }
        }

        static string Enchipher(string text, int num)
        {
            string result = string.Empty;

            foreach(char ch in text)
            {
                result += Cipher(ch, num);
            }

            return result;
        }

        static char Cipher(char ch, int num)
        {
            if (!char.IsLetter(ch))
            {
                return ch;
            }

            char d = char.IsUpper(ch) ? 'A' : 'a';
            return (char)((((ch + num) - d) % 26) + d);
        }

        static string Decipher(string text, int num)
        {
            return Enchipher(text, 26 - num);
        }
      
    }
}
