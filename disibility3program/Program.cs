
namespace disibility3program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello enter your number : ");
            int number = int.Parse(Console.ReadLine());
            if (number%3==0)
            {
                Console.WriteLine("is 3 disibility");
            }
            else
            {
                Console.WriteLine("is not 3 disibility");
            }
        }
    }
}
