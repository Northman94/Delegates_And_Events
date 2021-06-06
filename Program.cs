using System;

namespace Delegates_And_Events
{
    class MainClass
    {
        delegate int BinaryOp(int a, int b); //signature


        public static void Main(string[] args)
        {
            //variable based on delegate = delegate instance
            //BinaryOp someOperation = new BinaryOp(Add);

            BinaryOp someOperation  = Add;
                     someOperation += Mul;

            Console.WriteLine(someOperation(10, 10));
        }


        static int Add(int a, int b)
        {
            return a + b;
        }

        static int Mul(int a, int b)
        {
            return a * b;
        }
    }
}
