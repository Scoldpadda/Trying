﻿using System;
using System.Diagnostics;
using System.Threading;
using System.Linq;

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
                Console.WriteLine("Euclid algorithm: "); Console.WriteLine(Euclids(206, 40));
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
                Console.WriteLine(Small(199)); Console.WriteLine(Small(1999)); Console.WriteLine(Small(19999)); Print("Fermat test: ");
                Print(FermatRun(10, 10)); Console.WriteLine(); Console.WriteLine(FibForProcedure(9));
                Console.WriteLine(SumCube(1, 10)); Console.WriteLine(SumInteger(1, 10));
                Print(PiSumy(1, 1000) * 8); Console.WriteLine("Find Integral: ");
                Console.WriteLine(Integral(Cube(0.21), 0, 1, 0.01));
                Console.WriteLine("Simpson function: ");
                Console.WriteLine(SumIter(1, 10)); Console.WriteLine("Product:  ");
                Console.WriteLine(Product(2, 10));
                Console.WriteLine(ProductIter(2, 10)); Console.WriteLine(ProductFactorial(5)); Console.WriteLine("Accumulate: ");
                Console.WriteLine(Accumulate(1, 0, 4, 6)); Console.WriteLine(Evclid(206, 40));
                Console.WriteLine("Pi Sum test : "); Console.WriteLine(PiSumy(4, 10)); Console.WriteLine(PiSumm(4, 10));
                Console.WriteLine(Integral(14, 12, 15, 11)); Console.WriteLine(IntegralL(14, 12, 15, 11));
                Func<int, int >sqrt =x => { return x * x; };
                Func<int, int, int, int> L = (x, y, z) => { return 1 + 2 + sqrt(z); }; Console.WriteLine(L(1,2,3));
               Console.WriteLine(CalcF(5, 2)); Console.WriteLine(CalcF_Labmda(5, 2)); Console.WriteLine(CalcF_Let(5, 2)); 
                Console.WriteLine("Testing Half-interval function: ");
                Func<double, double> calc_for_Interval = x => { return Math.Sin(x); };
                //Console.WriteLine(HalfIntervalMethod(calc_for_Interval, 2.0, 4.0));
                Func<double, double> exprresion = x => { return (x*x*x)- (2*x-3); };
                Func<double, double> fix_cos = x => {return Math.Cos(x) ; };
                Func<double, double> fix_cos_plus_sin = x => { return Math.Cos(x) + Math.Sin(x); };
                /*Console.WriteLine(HalfIntervalMethod(exprresion, -1.0, 2.0));*/ Console.WriteLine("Finding fixed point of f: ");
                Console.WriteLine(Search(fix_cos, 2.0, 4.0)); Console.WriteLine(halfIntervalMethod(fix_cos, 2.0,4.0));

            }
        }
        static double halfIntervalMethod(Func<double , double> f , double a, double b)
        {
            Func<double, double> a_value = x => { return f(x); };
            Func<double, double> b_value = x => { return f(x); };
            double x1 = a_value(a);
            double x2 = a_value(b);
            if (x1 >0 & x2 <0)
            {
                return Search(f, a, b);
            }
            else if(x2>0 & x1<0)
            {
                return Search(f, b, a);
            }
            else
            {
                Console.WriteLine("Wrong sign.");
                return 1d;
            }
        }
        static double Search(Func<double, double> f, double neg_p, double pos_p)
        {
             
            Func<double, double, double> average = (x, y) => { return (neg_p + pos_p) / 2; };
            Func<Func<double, double>, double,double> test_value =(f, x) =>{ return f(x); };
            double mid_p = average(neg_p, pos_p);
            bool Close_Enough(double x, double y)
            {
                return x - y < 0.001; 
            }
            if (Close_Enough(neg_p, pos_p))
            {
                return mid_p;
            }
            else if (test_value(f, mid_p) > 0)
            {

                return Search(f, neg_p, mid_p);
            }
            else
            {
                return Search(f, mid_p, pos_p);
            }  
            
        }

        

static int CalcF_Let(int x, int y)
        {
            Func<int, int> sqrt = x => { return x * x; };
            Func<int, int, int> formula = (a, b) =>
           {
               return x * sqrt(a) + y * (b) + (a * b);
           };
            return formula((1 + x * y), 1 - y);
        }
        static int CalcF_Labmda(int x, int y )
        {
            Func<int, int> sqrt = x => { return x * x; };
            Func<int, int, int> Formula = (a, b) => { return x * (sqrt(a)) + y*b  + a*b     ; };
            return Formula((x * y) + 1, 1 - y);
        }

        static int CalcF(int x, int y)
        {
            
            Func<int, int> sqrt = x => {return x * x; };
            int f_helper(int a, int b)
            {
                return ((x * (sqrt(a)) + (y*b) + (a*b)));
            }
            return f_helper((x * y) + 1, 1 - y);
        }
        static double IntegralL(double f, double a, double b, double dx)
        {
            Func<double, double> AddX = x => { return x + dx; };
            return SumDouble((f*(a+ (dx/2.0))),AddX(b));
        }
        static double PiSumm(double a, double b)
        {
            Func<double, double> expression = x => { return 1.0 / (x + 2) * x; };
            Func<double, double> Add4 = x => { return x + 4; };
            return SumDouble((expression(a)), Add4(b));
        }
        static int Evclid(int a, int b)
        {      
            if(b==0)
            {
                return a;
            }
            else
            {
                return Evclid (b, Devide(a,b));
            }
        int Devide(int a, int b)
            {
                return a % b;
            }
     
        }
        static int Accumulate(int combiner, int nullValue, int a, int b)
        {
            int Next(int a) { return a+1; }
            if (a > b) { return combiner; }
            else
            {
                return a+b +  Accumulate(combiner, nullValue, ((a * Product(Next(a), b) + (SumInteger(Next(a), b)))), b); 
               
            }
        }
        static int ProductFactorial(int n)
        {
           int Id(int x) { return x; }
            int Next(int x) { return x + 1; }
            return ProductIter(Id(1), Next(n));
        }

        static int Product(int a, int b)
        {
            if(a>b)
            {
                return 1;
            }
            else
            {
                return a * Product(a + 2, b);
            }
        }
        static int ProductIter(int a,int b)
        { return Iter(a, 1);
            int Iter(int a, int result)
            {
                 if(a>b)
                {
                    return result;
                }
                else
                {
                    return a * Iter(a+2, result);
                }
            }
        }


        static int SumIter(int a, int b)
        {
            int Iter(int a, int result)
            { 
                if(a>b) { return result; }
                else
                {
                    return Iter(a + 1, result + a);
                }
            }
            return Iter(a, 0);
        }
        static double Integral(double f, double a, double b, double dx)
        {
            double AddDx(double x)
            {
                return x + dx;
            }
            return dx * SumDouble (f * (a + AddDx(b) + dx/2.0),dx);
        }
        static double SumDouble(double a, double b)
        {
            if (a > b) { return 0; }
            else
            {
                return a + SumDouble(a + 1.0, b);
            }
        }
        static double PiSumy(int a, int b)
        {
            double PiTerm(int x)
            {
                return (1.0 / (x * (x + 2)));
            }
            double PiNext(int x) { return x + 4; }
            return SumDouble(PiTerm(a),PiNext(b));
        }
        static int SumInteger(int a, int b)
        {
            return SumofInteger(Identity(a), Inc(b));
        }
        static int Identity(int a)
        {
            return a;
        }
        static int Inc(int a)
        {
            return a++;
        }
        static int SumCube(int a, int b)
        {
            return SumOfCube(a, Inc(b));
        }

        static double PiSum(int a, int b)
        {
            if (a > b) { return 0; }
            else
            {
                return (1.0 / a * (a + 2)) + PiSum(a + 4, b);
            }
        }
        static int SumofInteger(int a, int b)
        {
            if (a > b) { return 0; }
            else
            {
                return a + SumofInteger(a + 1, b);
            }
        }
        static int SumOfCube(int a, int b)
        {
            Func<int, int> cube = x => x * x * x;
            if(a>b)
            {
                return 0;
            }
            else
            {
                return cube(a) + SumOfCube(a + 1, b);
            }
        }
        static int FibForProcedure(int value)
        {
            return Compute(1,0,value);
            int Compute(int a, int b, int counter)
            {
                if (counter == 0)
                {
                    return b;
                }
                else
                {
                    return Compute((a + b), a, counter - 1);
                }
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
