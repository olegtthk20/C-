using System;
using System.IO;

namespace TööN1
{
    class Program
    {
        static void Main(string[] args)
        {
            // WORK NUMBER 1
            //Console.WriteLine("So, hello lets learn maths just a litle bit \n You should write a numbers to me \n And i will solve this task with the numbers you gave me \n the task is C = (a + b) * 11z - 12 * x , \n you should write me a, b, z and x");
            //int a = 0;
            //int b = 0;
            //int z = 0;
            //int x = 0;
            //Console.WriteLine("at first write me a...:");
            //a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("secondary write me b...:");
            //b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("now you should write me z...:");
            //z = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("and to end it write me x...:");
            //x = Convert.ToInt32(Console.ReadLine());

            //int c = (a + b) * (11 * z) - 12 * x;
            //Console.WriteLine(c);
            //Console.ReadLine();
            //StreamWriter failesse = new StreamWriter(@"..\..\andmed.txt", true);
            //failesse.WriteLine("your solution is {0}",c);
            //failesse.Close();

            //WORK NUMBER 2

            //Console.WriteLine("Let's introduce ourselves.\n My name is C# and we will work together for a long time said your teacher.\n Now it's your time to say something about you");
            //Console.WriteLine("you don't know how to di it? Let me teach you).\n At firts you should say your Name Surname and Patronymic...:");
            //string nsp = Console.ReadLine();
            //Console.WriteLine("Now You should say in which group you are...:");
            //string gp = Console.ReadLine();
            //Console.WriteLine("Now it's the time to write which variant are you doing");
            //string vari = Console.ReadLine();
            //Console.WriteLine("By the way, How old are you");
            //string age = Console.ReadLine();
            //Console.WriteLine("What is your sex...:");
            //string sex = Console.ReadLine();
            //Console.WriteLine("Number of your laby work...:");
            //string lab = Console.ReadLine();
            //Console.WriteLine("And at the end of this name of your lab work");
            //string endlab = Console.ReadLine();
            //Console.WriteLine("Thank you for introduction, it was nice to meet you {0}", nsp);
            //StreamWriter failesse = new StreamWriter(@"..\..\andmed.txt",true);
            //failesse.WriteLine(nsp, gp, vari, age, sex, lab, endlab);
            //failesse.Close();
            //Console.ReadLine();


            //WORK WHICH WAS DONE WITH TEACHER

            string[] sonad = new string[7] { "aaa", "bbb", "ccc", "ddd", "eee", "fff", "ggg" };
            foreach (string sona in sonad) 
            {
                Console.WriteLine(sona);
            }
            for (int i = 0; i < sonad.Lenght; i++)
            {
                Console.WriteLine(sonad[i]);
            }
            ConsoleKeyInfo key = new ConsoleKeyInfo();
            do
            {
                Console.WriteLine("Vajuta Escape");
                key = Console.ReadKey();
            } while (key.Key!=ConsoleKey.Escape);
            double num1 = 8.82831941;
            num1 = Math.Round(num1, 5);
            Console.WriteLine(num1.ToString());
            Console.ReadKey();
            Console.BackgroundColor = ConsoleColor.DarkGray;// background color change
            Console.ForegroundColor = ConsoleColor.Red;// text color change
            Console.Clear();// to complete the color change
            Console.WriteLine("Hello World!");// console.writeline is writing something ito console
            Random rnd = new Random();// making function to randomize numbers
            Console.WriteLine("jah - random, ei - sisetan number ise");
            string soov = Console.ReadLine();// reading lines and saving them
            int num = 0;
            if (soov == "jah")// if you wish is to random the day
            {
                num = rnd.Next(1, 8);// randoming
            }
            else// if you want to write the day by yourself
            {
                try
                {
                    num = Convert.ToInt32(Console.ReadLine());//converting numbers to write them on a keyboard
                    Console.WriteLine("Päeva number: {0}", num.ToString());// writes the day
                }
                catch (SystemException)
                {
                }
            }
            string nimetus = "";//making nimetus to string
            switch (num)//something like if else
            {
                case 1: nimetus = "esmaspäev"; break;
                case 2: nimetus = "teisipäev"; break;
                case 3: nimetus = "´kolmapäev"; break;
                case 4: nimetus = "neljapäev"; break;
                case 5: nimetus = "reede"; break;
                case 6: nimetus = "laupäev"; break;
                case 7: nimetus = "pühapäev"; break;
                default:
                    nimetus = "viga!";// if number is out of maximum destination it writes an error in console
                    break;// stopping
            }
            Console.WriteLine(nimetus);// writing func named nimetus
            StreamWriter filesse = new StreamWriter(@"..\..\andmed.txt", true);
            filesse.WriteLine("Number oli {0},päev on {1}", num.ToString(), nimetus);
            filesse.Close();
            Console.WriteLine("filis on salvesstatud: Number oli{0}" + num.ToString() + "päev on{1}" + nimetus);
            StreamReader filest = new StreamReader(@"..\..\andmed.txt", true);
            string a = filest.ReadToEnd();
            Console.WriteLine("failis oli seda: \n" + a);



            Console.ReadLine();//blocking console not to close
        }
    }
}
