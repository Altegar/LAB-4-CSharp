// Сушинський Ігор
// Лабораторна робота № 4
// Конструктори та перевантаження операцій для класів.
// Варіант 3

namespace LAB4
{
    internal class Program
    {
        public static void Main()
        {
            var a = new Complex(1, 1);
            var b = new Complex(1, 1);
            var c = new Complex(1, 1);
            Console.WriteLine(a);
            Console.WriteLine(a++);

            Console.WriteLine("im: ");
            double im = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("re: ");
            double re = Convert.ToDouble(Console.ReadLine());
            Complex x = new(im, re);
            Complex y = new();
            y = a * (x ^ 2) + b * x + c;
            string cplx = y.ToString();
            Console.WriteLine("Result: y = a*(x^2) + b*x + c:\n{0}", cplx);
        }
    }
}