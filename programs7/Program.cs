namespace programs7
{
    internal class Program
    {
        static void Main(string[] args)
            //write a program to find area & perimeter from length & breadth
        {
            Console.WriteLine("Enter the Length=");
            double length=double.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Breadth or Height= ");
            double breadth=double.Parse(Console.ReadLine());

            double perimeter = 2 * (length + breadth);
            double area = length * breadth;

            Console.WriteLine("Perimter is=" + perimeter);
            Console.WriteLine("Area is= " + area);


        }
    }
}