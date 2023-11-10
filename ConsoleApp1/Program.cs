namespace ConsoleApp1
{
    internal class Program
    {
        static int Topla(int a, int b)
        {
            Console.WriteLine("birinci metot çeğrıldı");
            return a + b;
        }

        static int Topla(int a, float b)
        {
            Console.WriteLine("ikinci metot çeğrıldı");

            return a + (int)b;
        }
        static int Topla(int a, int b,int c)
        {
            Console.WriteLine("üçüncü metot çeğrıldı");
            return a + b+c;
        }
        static int Topla(int a, int b, int c,int d)
        {
            Console.WriteLine("dördüncü metot çeğrıldı");
            return a + b + c+d;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Topla(b:10,a:34));
        }
    }
}