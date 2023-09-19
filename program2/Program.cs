namespace program2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, sum ,sub,mul,mod,div;
            a = 10;
            b = 20;
            sum = a + b;
            sub = b - a;
            mul = a * b;
            mod = b % a;
            div=  b / a;
            Console.WriteLine("Sum is::"+sum);
            Console.WriteLine("Subtraction is::" + sub);
            Console.WriteLine("Multiplication is::" + mul);
            Console.WriteLine("Modulas value is::" + mod);
            Console.WriteLine("Divison is::" + div);
            Console.WriteLine("Greater Value from A & B::" +(a <= b)); //boolean condition
            Console.WriteLine("Smaller Value from A & B::" + (a >= b));



                     
                
                }
    }
}