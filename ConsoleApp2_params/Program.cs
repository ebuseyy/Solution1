namespace ConsoleApp2_params
{
    internal class Program
    {
        static int Topla(params int[] a)
        {
            int t = 0;
            for (int i = 0; i < a.Length; i++)
            {
                t += a[i];
            }
            return t;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Topla(3,5));
            Console.WriteLine(Topla(3, 5,7));
            Console.WriteLine(Topla(3, 5, 7,8));
            Console.WriteLine(Topla(3, 5, 7, 8,15));
        }
    }
}