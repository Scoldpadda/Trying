using System;
using System.Diagnostics;
using System.Threading;

namespace SICP_course
{
    class Program
    {
        static void Main(string[] args)
        {
            { // Имена и окружения
                float pi = 3.14159f;
                int radius = 10;
                float result = ((radius * radius) * pi);
                float circumference = (2 * pi * radius);
                Console.WriteLine(result); Console.WriteLine(circumference);
            }
            { // Вычисление комбинаций
                int kombination = (((4 * 6) + 2) * (3 + 5 + 7));
                Console.WriteLine(kombination);
            }
            { // Составные процедуры
                Func<int, int> square = x => x * x; // составные процедуры  - в C# назывется метод(функция).
                Console.WriteLine(square(5)); ;
                Console.WriteLine((square((5 * 3) / 2)));
                Console.WriteLine(square(square(5))); // x^2
                Console.WriteLine(square(2) + square(3)); // x^2 + y^2; 
                Func<int, int, int> SummOfSquare = (x, y) => square(x) + (square(y)); // возвращяет сумму квадратов 
                Console.WriteLine(SummOfSquare(5, 2));
            }
            {
                Func<int, int, bool> ABS = (x, y) =>
                {
                    if (x < y)
                    {
                        Console.WriteLine("x < y ");
                    }
                    else
                    {
                        Console.WriteLine("x !< y");
                    }
                    return false;
                };
                ABS(5, 1);
            }
            {
                int a = 3;
                int b = a + 1;
                int result = (a + b + (a * b)); Console.WriteLine("Result ");
                Console.WriteLine(result);
                if (b > a & b > (a * b))
                {
                    Console.WriteLine(b + " True");
                }
                else
                {
                    Console.WriteLine(a + " False");
                }
                if (b > a) { int c = b + a + 2; }
                if (a > b) { a++; a--; } else if (a < b) { b++; b--; } else { int g = -1; }
            }
            {
                Func<int, int> square = x => (x * x);
                Func<int, int, int, int> ABS = (x, y, z) =>
                {
                    int[] numbers = new int[] { x, y, z };
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        for (int j = i + 1; j < numbers.Length; j++)
                        {
                            if (numbers[i] < numbers[j])
                            {
                                int t = numbers[i]; numbers[i] = numbers[j]; numbers[j] = t;
                            }
                        }
                    }
                    int max = numbers[0];
                    int max1 = numbers[1];
                    return square(max) + square(max1);
                };
                Console.WriteLine("Числа квадратов");
                Console.Write($"{square(7)}  +  {square(5)}  +  {square(3)}");
                Console.WriteLine("Принятие трёх аргументов и возврат суммы двух бОльших числов квадрата: ");
                Console.WriteLine(ABS(3, 4, 7));
            }
            {
                Func<int, int, int, int> abs = (x, y, z) =>
               {
                   int max0 = 0; int max1 = 0; int max2 = 0;
                   if (x > y | x > z)
                   {
                       max0 = x;
                   }
                   if (y > x | y > z)
                   {
                       max1 = y;
                   }
                   if (z > x | z > y)
                   {
                       max2 = z;
                   }
                   return max1 + max2 + max0;

               }; Console.WriteLine();
                Console.WriteLine("M"); Func<int, int> square = x => (x * x);
                Console.WriteLine(abs(square(3), square(4), square(7)));
            }
            {
                Func<int, int, int> test = (x, y) =>
                {
                    if (x == 0)
                    {
                        return 0;
                    }
                    else
                    {
                        return y;
                    }
                };
            }
            {
                Func<double, double> square = x => x * x;
            }
            {
                Console.WriteLine("Explicite recoursive compute factorial: ");
                Console.WriteLine(LinerRecursiveFactorial(6));
                Console.WriteLine("Compute with only Iter: ");
                Console.WriteLine(IterativeFactorial(6));
                Console.WriteLine("Max-Count procedure for compute factorial: ");
                Console.WriteLine(IterativeFactorialWithMaxCount(6));
            }
            { // exercise 1.9
                Console.WriteLine("xercise 1.9");
                Console.WriteLine(Define_first(4, 5)); ;
                Console.WriteLine("_________________________________________");
                Console.WriteLine(Define_Second(4, 5));
            }
            {  // Exercise 1.10 Ackerman function
                Console.WriteLine("Ackerman function: ");
                Console.WriteLine("__________________________________");
                Console.WriteLine("Ackerman equal 1 and 10");
                Console.WriteLine(Ackerman(1, 10));
                Console.WriteLine("Ackerman equal 2 and 4");
                Console.WriteLine(Ackerman(2, 4));
                Console.WriteLine("Ackerman equal 3 and 3");
                Console.WriteLine((Ackerman(3, 3)));
                Console.WriteLine("Factiriality compute");
                Console.WriteLine("Function F for Ackerman (0, n)");
                Console.WriteLine(F(4)); Console.WriteLine(G(4)); Console.WriteLine(H(4));
                Console.WriteLine(H(3)); Console.WriteLine("Fibonaicci of : ");
                Console.WriteLine(Fibonacci(5));
                Console.WriteLine("Golden ratio of : ");
                Console.WriteLine(GoldenRatio(5));
                Console.WriteLine("Fibonacci compute with using iterativly procedure: ");
                Console.WriteLine(FibonacciIterativly(8));
                Console.WriteLine(FibonacciIterativly(11)); Console.WriteLine(FibonacciIterativly(5));
                Console.WriteLine("Coin changer: "); Console.WriteLine(CountChanger(100));
                Console.WriteLine("Exercise 1.11: "); Console.WriteLine(RecusriveCompute(4));
                Console.WriteLine();
                Console.WriteLine(Fib(8)); Console.WriteLine(Fib(11));
                Console.WriteLine();
                Console.WriteLine("Exercise 1.11: ");
                //  Console.WriteLine(RecusriveCompute(30));
                // Console.WriteLine(IterativeCompute(30));
                Console.WriteLine(FibMy(6));
                Console.WriteLine("Pascal tringle");
                Console.WriteLine(Pascal(3, 2));
                Console.WriteLine("Exercise 1.15. Comppute sin r: ");
                Console.WriteLine(Sine(12.15, 0));
                Console.WriteLine("Exponent task: ");
                Console.WriteLine(Power(2, 4));
                Console.WriteLine("Iter Exponent: "); Console.WriteLine(PowerIter(2, 4));
                Console.WriteLine(PowerNew(2, 4)); Console.WriteLine(); Console.WriteLine(PowerExpt(2, 4));
                Console.WriteLine();
                Console.WriteLine(PowerExpt(3, 6));
                Console.WriteLine(); Console.WriteLine(MyPower(3, 3)); Console.WriteLine(MyPower(3, 5));
                Console.WriteLine(); Console.WriteLine(ExpAlg(3, 3)); Console.WriteLine(ExpAlg(3, 4));
                Console.WriteLine("Euclid algorithm: "); Console.WriteLine(Euclids(60, 36));
                Console.WriteLine("Searching smallest division: ");
                Console.WriteLine(SmallestDevisior(10));
                Console.WriteLine("Testing Primary: ");
                Console.WriteLine(Exponent(5, 15));
                Console.WriteLine();
                Console.WriteLine(ExponentLog(5, 15));
                Console.WriteLine("Exercise 1.21: "); Console.WriteLine("Value = 199");
                Console.WriteLine(Smallest(199)); Console.WriteLine(SmallestDevisior(199));
                Console.WriteLine("Value = 1999"); Console.WriteLine(Smallest(1999)); Console.WriteLine(SmallestDevisior(1999));
                Console.WriteLine("Value = 19999"); Console.WriteLine(Smallest(19999)); Console.WriteLine(SmallestDevisior(19999));
                Console.WriteLine(Small(199)); Console.WriteLine(Small(1999)); Console.WriteLine(Small(19999));  Print("Fermat test: ");
                Print(FermatRun(15,3));
                
              
            }
        }
        static int ModExpo(int b, int exp, int m)
        {
            Func<int, int> sqrt = x => x * x;
            bool Even(int value) { return value % 2 == 0; }
            if (exp == 0) { return 1; }
            else if(Even(exp))
            {
                return sqrt(ModExpo(b, exp / 2, m)) % m;
            }
            else
            {
                return b * ModExpo(b, exp - 1, m) % m;
            }
        }
       static  bool TestingFermat(int n)
        {
            Random rnd = new Random();
            bool TryIt(int a)
            {
                return ModExpo(a, n, n) == a;
            }
            return TryIt(rnd.Next(0,n-1) +1);
        }
     static   bool FermatRun(int n, int NumberOfTime)
        {
            if(NumberOfTime == 0) { return true; }
            else if(TestingFermat(n))
            {
                return FermatRun(n, NumberOfTime-1);
            }
            else
            {
                return false;
            }
        }
        static int AckermanMan(int x, int y)
        {
            if (x == 0)
            {
                return y * 2;
            }
            else if (y == 1)
            {
                return 2;
            }
            else if (y == 0)
            {
                return 0;
            }
            else
            {
                return AckermanMan(x - 1, AckermanMan(x, y - 1));
            }
        }

        static public int Define_first(int a, int b)
        {
            if (a == 0)
            {
                return b;
            }
            else
            {
                return INC(DEC(a) + b);
            }
            int INC(int x)
            {
                return x + 1;
            }
            int DEC(int x)
            {
                return x - 1;
            }

        }
        static public int Define_Second(int a, int b)
        {
            if (a == 0)
            {
                return b;
            }
            else
            {
                return (DEC(a) + INC(b));
            }
            int INC(int x)
            {
                return x + 1;
            }
            int DEC(int x)
            {
                return x - 1;
            }
        }

        static public int LinerRecursiveFactorial(int n)
        {
            if (n < 1)
            {
                return 1;
            }
            else
            {
                return n * (LinerRecursiveFactorial(n - 1));
            }
        }
        static public int IterativeFactorial(int n)
        {
            int Iter(int result, int counter)
            {
                if (counter > n)
                {
                    return result;
                }
                else
                {
                    return Iter(result * counter, counter + 1);
                }
            }
            return Iter(1, 1);
        }
        static public int IterativeFactorialWithMaxCount(int n)
        {
            int Iter(int result, int counter, int maxCount)
            {
                if (counter > maxCount)
                {
                    return result;
                }
                else
                {
                    return Iter((result * counter), counter + 1, maxCount);
                }
            }
            return Iter(1, 1, n);
        }
        static int Ackerman(int x, int y)
        {
            if (x == 0)
            {
                return y * 2;
            }
            else if (y == 1)
            {
                return 2;
            }
            else if (y == 0)
            {
                return 0;
            }
            else
            {
                return Ackerman((x - 1), (Ackerman(x, y - 1)));
            }
        }
        static int F(int n)
        {
            return Ackerman(0, n);
        }
        static int G(int n)
        {
            return Ackerman(1, n);
        }
        static int H(int n)
        {
            return Ackerman(2, n);
        }
        static int Fibonacci(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else if (n == 0)
            {
                return 0;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }
        static double GoldenRatio(int n)
        {
            double formula = (1 + Math.Sqrt(5)) / 2;
            return Math.Pow(formula, n) / Math.Sqrt(5);
        }
        static int Katalana(int n)
        {
            int Factorial(int x)
            { // C(n) = (2n)!
              // /n!(n+1)!,
                if (x < 1)
                {
                    return 1;
                }
                else
                {
                    return x * Factorial(x - 1);
                }
            }
            int UperCompute = (2 * Factorial(n));
            int DownCompute = Factorial(n) * (Factorial(n + 1));
            return UperCompute / DownCompute;

        }
        static int FibonacciIterativly(int n)
        {
            return FibIter(1, 0, n);
            int FibIter(int a, int b, int counter)
            {
                if (counter == 0)
                {
                    return b;
                }
                else
                {
                    return FibIter((a + b), a, (counter - 1)); //   4 // 1 1 4 // 2 1 3 // 3 2 3 // 5 3 2 // 8 5 1 // 13 8 0  
                }
            }

        }
        static int CountChanger(int value)
        {
            return CC(value, 5);
        }
        static int CC(int amount, int kindOfCoins)
        {
            if (amount == 0) { return 1; }
            else if (amount < 0 | kindOfCoins == 0) { return 0; }
            else
            {
                return (CC(amount, (kindOfCoins - 1)) + CC(amount - TypeOfCoins(kindOfCoins), kindOfCoins));
            }
        }
        static int TypeOfCoins(int type)
        {
            if (type == 1) { return 1; }
            else if (type == 2) { return 5; }
            else if (type == 3) { return 10; }
            else if (type == 4) { return 25; }
            else if (type >= 6) { return 0; }
            else
            {
                return 50;  // if (type ==5);
            }
        }
        static int RecusriveCompute(int n)
        {
            if (n < 3)
            {
                return n;
            }
            else
            {
                return RecusriveCompute(n - 1) + RecusriveCompute(n - 2) + RecusriveCompute(n - 3); // ifn == 4   => 3+2+1 // n = 3 => 2+1+0  // n =2 => 2 total = 6+3+2 = 9
            }
        }
        static int IterativeCompute(int n)
        {
            return Iter(2, 1, 0, n);
            int Iter(int a, int b, int c, int count)
            {
                if (count == 0)
                {
                    return c;
                }
                else
                {
                    return Iter((a + b + c), a, b, count - 1);
                }
            }
        }
        static int FibMy(int n)
        {
            return Iter(1, 0, n);
            int Iter(int a, int b, int count)
            {
                if (count == 1)
                {
                    return b;
                }
                else
                {
                    return Iter((a + b), a, count - 1); // n = 3 // 1 0 3 // 1 1 2 // 2 1 1 // 3 2 0 
                }
            }
        }


        static int Fib(int n)
        {
            return FibIter(1, 0, n);
            int FibIter(int a, int b, int count)
            {
                if (count == 0)
                {
                    return b;
                }
                else
                {
                    return FibIter((a + b), a, (count - 1));
                }
            }
        }
        static int Pascal(int row, int element)
        {
            if (row == 1 || element == row)
            {
                return 1;
            }
            //  else if(element>1 & element<row)
            else
            {
                return Pascal(row - 1, element) + Pascal(row - 1, element - 1);
            }
        }
        static double Cube(double x)
        {
            return x * x * x;
        }
        static double P(double x)
        {
            return ((3 * x) - (4 * (Cube(x))));
        }
        static double Sine(double angle, int counter)
        {
            if (angle < 0.1)
            {
                return angle;
            }
            else
            {
                Console.Write(counter + " ");
                return P(Sine(angle / 3.0, counter + 1));
            }
        }
        static int Power(int b, int n)
        {
            if (n == 0) { return 1; }
            else
            {
                return b * (Power(b, n - 1));
            }
        }
        static int PowerIter(int b, int n)
        {
            return Iter(b, n, 1);
            int Iter(int x, int counter, int result)
            {
                if (counter == 0)
                {
                    return result;
                }
                else
                {
                    return Iter(x, counter - 1, x * result);
                }
            }

        }
        static int PowerNew(int b, int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return b * PowerNew(b, n - 1);
            }
        }
        static int PowerExpt(int b, int n)
        {
            Func<int, int> sqrt = x => x * x;
            if (n % 2 == 0)
            {
                return sqrt(PowerExpt(b, n / 2)); // 3 6  //  3 3 
            }
            else
            {
                return b * (Power(b, n - 1));
            }
        }
        static int MyPower(int b, int n)
        {
            Func<int, int> sqrt = x => x * x;
            return Iter(b, n, 1);
            int Iter(int b, int n, int a)
            {
                if (n == 0)
                {
                    return a;
                }
                else if (n % 2 == 0)
                {
                    return Iter(sqrt(b), n / 2, a);
                }
                else
                {
                    return Iter(b, n - 1, a * b);
                }
            }
        }
        static int ExpAlg(int a, int b)
        {
            Func<int, int> Doubling = x => x * 2;
            Func<int, int> Halfe = x => x / 2;
            // 3,4

            if (b == 1) { return a; }
            else if (b % 2 == 0)
            {
                return ExpAlg(Doubling(a), Halfe(b));
            }
            else
            {
                return ExpAlg(a, (b - 1)) + a;
            }
        }
        static int Euclids(int a, int b)
        {
            if (b == 0)
            {
                return a;
            }
            else
            {
                return Euclids(b, a % b);
            }
        }
        static int SmallestDevisior(int n)
        {
            return FindSmallest(n, 2);
            int FindSmallest(int n, int test)
            { Func<int, int> sqrt = x => x * x;
                if (sqrt(test) > n)
                {
                    return n;
                }
                else if (Devides(test, n))
                {
                    return test;
                }
                else if (Prime(test))
                {
                    return test;
                }
                else
                {
                    return FindSmallest(n, test + 1);
                }
            }
            bool Prime(int n)
            {
                return n == SmallestDevisior(n);
            }
            bool Devides(int a, int b)
            {
                if (b % a == 0) { return true; }
                else { return false; }
            }
        }
        static int Smallest(int GCD)
        {
            return Find(GCD, 2);
            int Find(int value, int test)
            {
                Func<int, int> sqrt = x => x * x;
                bool Devide(int value, int test)
                {
                    return value % test == 0;
                }
                if(sqrt(test)>value)
                {
                    return value;
                }
                else if(Devide(value, test))
                {
                    return test;
                }
                else
                {
                    return Find(value, test + 1);
                }
            }
        }

            static int TestPriming(int a, int n)
        {
            int remainder = Power(a, n) % n;
            int Power(int a, int n)
            {
                if (n == 1)
                {
                    return a;
                }
                else
                {
                    return a * Power(a, n - 1);
                }
            }
            return remainder;
        }
        static int ExpMod(int b, int exp, int m)
        {
            Func<int, int> sqrt = x => x * x;
            bool Even(int exp) { return exp % 2 == 0; }
            if (exp == 0) { return 1; }
            else if (Even(exp))
            {
                return sqrt(ExpMod(b, exp / 2, m)) % m;
            }
            else
            {
                return (b * ExpMod(b, exp - 1, m)) % m;
            }
        }
        static int Exponent(int b, int n)
        {
            Console.Write("Counter = " + n + " ");
            if (n == 1) { return 1; } else
            {
                return b * Exponent(b, n - 1);
            }

        }
        static int ExponentLog(int b, int n)
        {
            int counter = 0;

            Func<int, int> sqrt = x => x * x;
            if (n == 0) { return 1; }
            else if (n % 2 == 0)
            {
                counter++;
                Console.Write("Log = " + counter + " ");
                return sqrt(ExponentLog(b, n / 2));
            }
            else
            {
                counter++;
                Console.Write("Log = " + counter + " ");
                return b * (ExponentLog(b, n - 1));
            }
            Console.Write("Log = " + counter);
        }
        static string DisplayTime()
        {
            Stopwatch time = new Stopwatch();
            TimeSpan ts = time.Elapsed;
            string ShowElapsed = ts.Seconds.ToString() ;
            return ShowElapsed;
        }
        static int Small(int a)
        {  
            Func<int, int> sqrt = x => x * x;
            int Smallest(int a, int b)
            {
                bool Devine(int a ,int b)
                {
                    return a%b == 0;
                }
                if(sqrt(b)>a)
                {
                    return a;
                }
                else if(Devine(a,b))
                {
                    return b;
                }
                else
                {
                    return Smallest(a, b + 1);
                }
            }
           return Smallest(a, 2);
        }
       
        static void Print<T>(T n)
        {
            Console.WriteLine(n);
        }
    }


    
}
