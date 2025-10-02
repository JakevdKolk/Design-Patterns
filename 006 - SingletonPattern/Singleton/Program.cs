namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ChocolateBoiler chocolate = ChocolateBoiler.GetInstance();
            ChocolateBoiler chocolate2 = ChocolateBoiler.GetInstance();

            chocolate.fill();
            chocolate.boil();
            chocolate.drain();
            Console.WriteLine(chocolate);

            Console.WriteLine(chocolate2);
        }
    }
}