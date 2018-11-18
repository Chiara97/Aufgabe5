using System;
using System.Text;

namespace Aufgabe5_Henri
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gib einen Satz ein:");
            string sentence = Console.ReadLine();
            Console.WriteLine(sentence);

            ReverseLetters(sentence);
            ReverseWords(sentence);
            Reversesentence(sentence);
        }
        static string ReverseLetters(string sentence)
        {
            char[] charArray = sentence.ToCharArray();
            Array.Reverse (charArray);

            Console.WriteLine(charArray);
            string a = charArray.ToString();
            return a;
        }

        static void ReverseWords(string sentence)
        {
            String[] stringArray = sentence.Split(' ');
            Array.Reverse (stringArray);
            sentence = String.Join(" ", stringArray);

            Console.WriteLine(sentence);
        }

        static void Reversesentence(string sentence)
        {
            String[] stringArray = sentence.Split(' ');
            StringBuilder sb = new StringBuilder();

            int i = 0;
            while (i < stringArray.Length)
            {
                sb.Append (ReverseLetters(stringArray[i]));
                sb.Append (" ");
                i++;                
            }
            sb.ToString();
        }        
    }
}
