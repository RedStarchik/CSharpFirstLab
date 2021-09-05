using System;

namespace ConsoleApp1
{
    public class FirstLab
    {
        public void FirstEx()
        {
            int firstVarCStyle;
            Int32 firstVarNetStyle;

            Single f;
            float f1;

            Double d;
            double d1;

            uint ui;
            UInt32 ui1;

            IntPtr ip;
            nuint ip1;
        }

        public void SecondEx()
        {
            int intVar = 5;
            int intVar1 = intVar;

            intVar = 1;
            Console.WriteLine(intVar);
            Console.WriteLine(intVar1);

            string strVar = "string";
            string strVar1 = strVar;

            strVar = "some bad words";
            
            Console.WriteLine(strVar);
            Console.WriteLine(strVar1);
        }
    }
}