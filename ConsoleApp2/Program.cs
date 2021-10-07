using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double z, p, q, f, k;//Объявление переменных
            f = 4;
            k = 9;
            p = 5;
            q = f / k;//Промежутчные вычисления
            z = (p / 2) * Math.Sqrt(1+(1/(16/3*Math.Pow(q,2)*(1+4/3*Math.Pow(q,2)))));
            Console.WriteLine("z={0:#.##}", z);//Округление числа до сотых
            Console.ReadKey();
        }
    }
}
