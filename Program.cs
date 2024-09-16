namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int roomNumber = 42;
            double price = 2.99;
            string courseName = "Computer Science";

            Console.WriteLine("This is room #" + roomNumber);
            Console.WriteLine("The price is " + price);
            Console.WriteLine("I am leaning a bit about " + courseName);

            string fullName;
            int gradYear; 

            fullName = "Carter Todd";
            gradYear = 2026;

            Console.WriteLine("My name is " + fullName + " and i'll graduate in " + gradYear);

            int radius;
            double area; 
            radius = 5;
            area = 5;
            Console.WriteLine(area = Math.PI * (radius * 2));
        }
    }
}
