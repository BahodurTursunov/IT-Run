/*
 * Vazifa baroi xona. Programma sozetonki az istifoda baranda yakeaz operatsiyai arifmetiki (+, -, *, /) pursad. 
 * Badi dohil kardani operatsiya, kamash 2 to raqamro baroi ijro kardani operatsiya vorid kunad. Dar ohir,
 * azrui malumothoi virid shuda, natijaro burorad. Mirol, Operatsiyai +, intixob karda, 2 va 10 ro dohil kunad,
 * programma 12 ro chop kunad. 
Baroi logikai har yak operatsiya, Method istifoda shavad, Swich case va If Else. 
baroi operatsiya Enumro istifoda bareton bo bextarin.
 */

namespace hw1
{
    enum MathOperation
    {
        Add = 1,
        Subtract = 2,
        Division = 3,
        Multiplication = 4
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Какую операцию хотите выполнить?\n" +
                "+\n" +
                "-\n" +
                "/\n" +
                "*");
            int operation = int.Parse(Console.ReadLine());

            int FirstNum = int.Parse(Console.ReadLine());
            int SecondNum = int.Parse(Console.ReadLine());
            MathOperations(operation,FirstNum, SecondNum);

        }
        static void MathOperations(int operation, int firstNum, int secondNum)
        {
            switch (operation)
            {
                case (int)MathOperation.Add: Console.WriteLine(firstNum + secondNum); break;

                case (int)MathOperation.Subtract: Console.WriteLine(firstNum - secondNum); break;

                case (int)MathOperation.Division: Console.WriteLine(firstNum / secondNum); break;

                case (int)MathOperation.Multiplication: Console.WriteLine(firstNum * secondNum); break;

                default:
                    Console.WriteLine("Эта операция не предусмотрена в моей программе"); break;
            }
        }

        public static int Add(int firstNum, int secondNum)
        {
            return firstNum + secondNum;
        }

        public static int Substract(int firstNum, int secondNum)
        {
            return firstNum - secondNum;
        }

        public static int Division(int firstNum, int secondNum)
        {
            if (firstNum == 0 || secondNum == 0)
                return 0;
            else
                return firstNum / secondNum;
        }

        public static int Multiplication(int firstNum, int secondNum)
        {
            if (firstNum == 0 || secondNum == 0)
                return 0;
            else
                return firstNum * secondNum;
        }
    }

   
}
