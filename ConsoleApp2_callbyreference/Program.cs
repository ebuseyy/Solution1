namespace ConsoleApp2_callbyreference
{
    internal class Program
    {
        static void degertipi(int[] deger)
        {
            deger[2] = 150;
        }
        static void Main(string[] args)
        {
            int[] a = { 10,45,67,89};

            Console.WriteLine(a[2]);
            degertipi(a);
            Console.WriteLine(a[2]);
        }
    }
}