using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1
{
    class Test
    {
        public string StudentName ;
        public int x;
    }
    class Program
    {
        static void ChangeReferenceType(Test std2)
        {
            std2.StudentName = "Steve";
        }

        static void Main(string[] args)
        {
            Test std1 = new Test();
            std1.StudentName = "Bill";
    
            ChangeReferenceType(std1);

            Console.WriteLine(std1.StudentName);
        }
     

        static void fun()
        {
            string name/* = "Ira"*/;
            Console.WriteLine("What`s your name?");
            name = Console.ReadLine();
            int age = 18;
            Console.WriteLine("input age");
            string str = Console.ReadLine();
            //age = int.Parse(str);
            bool falg = int.TryParse(str, out age);
            if (falg)
                Console.WriteLine($"Hello, name={name} age={age * 2}");
            else
                Console.WriteLine("error");
            //Console.WriteLine("Hello, " + "Ira");
            Console.WriteLine("Hello, " + name);
            Console.WriteLine("Hello, name={0} age={1}{0}", name, age);
            Console.WriteLine($"Hello, name={name} age={age*2}");
            int n = 2, k = 3;
            Console.WriteLine("hello"+ n + k);
            Console.WriteLine(n.ToString() + k);
            Console.WriteLine(n + k);
            var l = 4;
            int[] array = {1, 2, 3};
            int[] array2 = new int[3];
            for(int i=0; i<array.Length; i++)
            {
                Console.WriteLine($"array[{1}]={array[1]}");//?????
                array[1] *= 2;
            }
            foreach (var temp in array)
            { 
                //temp * = 2;
                Console.WriteLine($"array={temp}");
            }
            int a = 3;
            int b = 4;
            a = b; b = 9;
            Test test1 = new Test();
            Test test2 = new Test();
            test1.x = 8;
            test2.x = 9;
            test2 = test1;
            test1.x = 3;
            Console.WriteLine($"test1.x={test1.x}test2.x={test2.x}");
            int y = 6;
            float f = /*(float)*/y;
            y = (int)f;
            double d = f;
            f = (float)d;
            Console.WriteLine();
        }
    }
}