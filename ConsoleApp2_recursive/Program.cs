using System;
namespace ConsoleApp2_recursive
{
    public class islem
    {

    }
    internal class Program
    { 
        static void Main(string[] args)
        {
            int a=Convert.ToInt32(Console.ReadLine());
            islem2 o = new islem2();
            Console.WriteLine(o.F(a));

            // local method
            void ekranayaz(string a)
            {
                Console.WriteLine(a);
            }
        }
    }
}