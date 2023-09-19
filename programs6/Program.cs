namespace programs6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Program to find maximum between three numbers
            Console.WriteLine("Enter First Number= ");
            int num1=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number=");
            int num2=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Third Number");
            int num3=int.Parse(Console.ReadLine());

            if(num1>num2 && num1 > num3)
            {
                Console.WriteLine("Wow! Num1 is Greater");
            }
            else if(num2>num1 && num2 > num3)
            {
                Console.WriteLine("Wow ! Num2 is greater");
            }
            else
            {
                Console.WriteLine("Wow ! Num3 is greater");
            }
        }
    }
}