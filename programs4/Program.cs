namespace programs4
{
    internal class Program
    {
        static void Main(string[] args)
            //write a program to perform all arithmetic operation
        {

            Console.Write("Enter First Number=");
            double num1 =double.Parse(Console.ReadLine());
            Console.Write("Enter Second Number=");
            double num2 = double.Parse(Console.ReadLine());

            double sum = num1 + num2;
            double difference = num1 - num2;
            double product=num1* num2;
            double quotient = num1 / num2;
            double remainder=num1 % num2;
            Console.WriteLine("Sum =" + sum);
            Console.WriteLine("Difference=" + difference);
            Console.WriteLine("Product=" + product);
            Console.WriteLine("Quotient=" + quotient);
            Console.WriteLine("Remainder=" + remainder);





        }
    }
}