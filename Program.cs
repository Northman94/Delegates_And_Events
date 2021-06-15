using System;

namespace Delegates_And_Events
{
    class MainClass
    {
        delegate int BinaryOp(int a, int b); //Определили BinaryOp это [тип делегата]


        public static void Main(string[] args)
        {
            //Переменная с типом делегата, хранящая ссылку на метод:
            BinaryOp someOperation  = Add; // variable based on delegate = delegate instance;
                     someOperation += Mul; //Добавление нового метода в список;
            //Все последующие методы, кроме первого, добавляются в список через "+=";


            //Выше упрощенный вариант написания этого:
            //BinaryOp someOperation = new BinaryOp(Add);
            // Помещение ссылки на метод в переменную +
            // создание обьекта-экземпляра [типа делегата]


            //Вызов, который запустит очередь методов:
            Console.WriteLine(someOperation(10, 10));
        }


        static int Add(int a, int b) //Будет ругаться, если возвращаемое значение не int
        {
            return a + b;
        }

        static int Mul(int a, int b) 
        {
            return a * b;
        }
    }
}
