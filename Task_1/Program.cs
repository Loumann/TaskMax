using System;
using System.Linq;

//задание 2
namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            char[] charsEnglish = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            string wrongChars = "";


            line = Console.ReadLine();


            char[] inputLine = line.ToCharArray();

            foreach (char c in inputLine)
            {
                if (!charsEnglish.Contains(c))
                {
                    wrongChars += c + " ";
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

                    string str1 = line.Substring(0, line.Length / 2);
                    string str2 = line.Substring(line.Length / 2, line.Length / 2);


                    char[] charArray1 = str1.ToCharArray();
                    char[] charArray2 = str2.ToCharArray();
                    Array.Reverse(charArray1);
                    Array.Reverse(charArray2);


                    string s1 = new string(charArray1);
                    string s2 = new string(charArray2);
                    Console.WriteLine(s1 + s2);
                    return;
                }
                else
                {

                    Console.WriteLine("Не четное. Количество: " + line.Length);

                    char[] charArray1 = line.ToCharArray();
                    Array.Reverse(charArray1);
                    string a1 = new string(charArray1);

                    Console.WriteLine(a1 + line);
                    return;


                }
            }
        }
    }
}