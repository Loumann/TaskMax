using System;
using System.Linq;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            line = Console.ReadLine();


            Console.WriteLine(line.Length);


            if ((line.Length % 2) == 0)
            {
                Console.WriteLine("Четное");

                string str1 = line.Substring(0, line.Length / 2);   
                string str2 = line.Substring(line.Length / 2, line.Length / 2);


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

                Console.WriteLine("не Четное");

                char[] charArray1 = line.ToCharArray();
                Array.Reverse(charArray1);
                string a1 = new string(charArray1);

                Console.WriteLine(a1 + line);

                //наверное замудрил сильно, но я не понял немного как 2 char[] соеденить(что-то такое вроде было,я уже забыл если честно что там было :)), траблы были с выводом
                //в общем и целом, не получилось у меня немного, я поэтому я решил особо не парится и сделать так
            }

        }
    }
}
