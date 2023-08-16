using System;

namespace Generics
{
    class Program
    {
        public static void Pyramid(int start, int end)
        {
            for (int i = start; i < end; i++)
            {
                for (int spaces = 1; spaces < end - 1; spaces++) Console.Write(" "); //Spaces
                for (int j = 1; j < (2 * i) - 1; j++) Console.Write("*");
                Console.WriteLine();
            }
        }
        public static void Base(int rows)
        {
            for (int i = 0; i < rows*0.3; i++)
            {
                for (int spaces = 1; spaces < rows * 0.75; spaces++) Console.Write(" ");//spaces
                for (int j = 1; j < rows * 0.5; j++) Console.Write("*");
                Console.WriteLine();
            }
        }
        public static void Swap<T>(ref T s1,ref  T s2)
        {
            T temp = s1;
            s1 = s2;
            s2 = temp;
        }

        public static void GetInput<T>(T [] array)
        {
            object check = array.GetType();
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Enter {0} Value",i+1);
                string input = Console.ReadLine();
                //array[i] = (T)Convert.ChangeType(input, typeof(T));
                //array[i] = (T)int.TryParse(input, out array[i]);

            }

            foreach (var item in array)
            {
                Console.WriteLine(item);
                Console.WriteLine("---------------");
            }
        }
        static void Main(string[] args)
        {
            string a1 = "eferf";
            string a2 = "ferfe";
            Console.WriteLine(a1a2);
            //int[] array = new int[3];
            //string[] s1=new string[3];
            //GetInput<string>(s1);
            //int first = 2;
            //int second =5;

            //Student std1 = new Student("Ahsan", "BSSE-A");
            //Student std2 = new Student("Bilal", "BSCS-A");

            //Point<double,int> point = new Point<double,int>(10.4, 20);
            //point.X = 100;
            //point.Y = 200;
            //Console.WriteLine(point);
            //Console.WriteLine("Before Method Call");
            //Console.WriteLine("First\t\t\tSecond");
            //Console.WriteLine("{0}\t{1}",std1,std2);

            //Swap(ref std1,ref std2);

            //Console.WriteLine("After Method Call");
            //Console.WriteLine("First\t\t\tSecond");
            //Console.WriteLine("{0}\t{1}", std1, std2);


            

            //int rows = 15;
            //Pyramid(0, rows);
            //Pyramid(rows / 2, rows);
            //Pyramid(rows / 2, rows);
            //Base(rows);
        }
    }
}
