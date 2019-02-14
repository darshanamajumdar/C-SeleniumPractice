using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static void Anagram()
        {
            bool status = false;

            string s1 = "peek";
            string s2 = "keeP";

            s1.Replace(" ", "").ToLower();
            s2.Replace(" ", "").ToLower();

            if(s1.Length == s2.Length)
            {
                char[] s1arr = s1.ToCharArray();
                char[] s2arr = s2.ToCharArray();

                Array.Sort(s1arr);
                Array.Sort(s2arr);

                Console.WriteLine(s1arr);
                Console.WriteLine("After sorting --> "+ s2arr);

                if(s1arr.SequenceEqual(s2arr))
                {
                    status = true;
                }
            }
            else
            {
                status = false;
            }

            if(status)
            {
                Console.WriteLine("Both the strings " + s1 + " & " + s2 + " are anagram");
            }

            else
            {
                Console.WriteLine("Both the strings " + s1 + " & " + s2 + " are not anagram");
            }
        }

        public static void Pattern()
        {
            string userInput;
            int rowCount;

            Console.WriteLine("Enter the no.of rows..");
            userInput = Console.ReadLine();
            rowCount = Convert.ToInt32(userInput);

            for(int i=0; i<rowCount; i++)
            {
                for(int j=0; j<=i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }

        public static void OccuranceOfCharacter()
        {
            string str;
            Console.WriteLine("Enter the string..");
            str = Console.ReadLine();

            Dictionary<char, int> charCount = new Dictionary<char, int>();

            str.ToLower();
            char[] ch = str.ToCharArray();
            foreach(char ch1 in ch)
            {
                if(charCount.ContainsKey(ch1))
                {
                    charCount.Add(ch1, charCount.Count+1);
                }
                else
                {
                    charCount.Add(ch1, charCount.Count);
                }
            }
        }

        public static void Main()
        {
            // Program.Anagram();
            // Program.Pattern();
            Program.OccuranceOfCharacter();
        }
    }
}
