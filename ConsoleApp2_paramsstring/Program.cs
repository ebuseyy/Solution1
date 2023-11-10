namespace ConsoleApp2_paramsstring
{
    internal class Program
    {
        static string Topla(params string[] a)
        {
            string t = ""; ;
            for (int i = 0; i < a.Length; i++)
            {
                t += a[i];
            }
            return t;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Topla("3", "5"));
            Console.WriteLine(Topla("3", "5", "7"));
         }
    }
}