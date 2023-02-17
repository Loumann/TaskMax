using System;
using System.Collections.Generic;
using System.Linq;

//задание 2
namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            char[] charsEnglish = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            char[] chars = line.ToCharArray();
            string wrongChars = "";
            Dictionary<char, int> charCount = new Dictionary<char, int>();


            foreach (char c in chars)
            {
                if (!charsEnglish.Contains(c))
                {
                    wrongChars += c + " ";
                }
            }


            foreach (char c in chars)
            {
                if (charCount.ContainsKey(c))
                {
                    charCount[c]++;
                }
                else
                {
                    charCount.Add(c, 1);
                }
            }

            if (wrongChars != "")
            {
                Console.WriteLine("Символы не прошедшую проверку: {0}", wrongChars);
            }


            else
            {

                if ((line.Length % 2) == 0)
                {
                    Console.WriteLine("Четное. Количество: " + line.Length);

                    var str1 = line.Substring(0, line.Length / 2);
                    var str2 = line.Substring(line.Length / 2, line.Length / 2);


                    char[] charArray1 = str1.ToCharArray();
                    char[] charArray2 = str2.ToCharArray();
                    Array.Reverse(charArray1);
                    Array.Reverse(charArray2);


                    string s1 = new string(charArray1);
                    string s2 = new string(charArray2);
                    Console.WriteLine(s1 + s2);
                }
                else
                {

                    Console.WriteLine("Не четное. Количество: " + line.Length);

                    char[] charArray1 = line.ToCharArray();
                    Array.Reverse(charArray1);
                    string a1 = new string(charArray1);

                    Console.WriteLine(a1 + line);
                    


                }
                Console.WriteLine("----------------------");


                foreach (KeyValuePair<char, int> kvp in charCount)
                {
                    Console.WriteLine("{0}: {1}", kvp.Key, kvp.Value);
                }
            }
        }
    }
}