namespace programs5
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //To Check maximum number between two numbers
           
            Console.WriteLine("Enter First Number= ");
            int num1=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            int num2=int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("Num1 is Greater");
            }
            else if (num1 == num2)
            {
                Console.WriteLine("Num1 is equal to num2");          }
            else
            {
                Console.WriteLine("Num2 is Greater");
            }
        }
    }
}