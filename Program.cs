using System.Threading.Channels;

namespace BasicsOfOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Here we create a new object from the class Circle, it must have a paremeter, for this one it's 5.
            Circle circle1 = new Circle(5);
            // Once we have our circle, we call the method .GetArea() to print out the actual area of the circle.
            // Method to calculate the circumference of the circle as well.
            // If it was a sphere, we call a method as if it were a sphere.
            Console.WriteLine("Cirkel med radie 5:");
            Console.WriteLine($"Arean: {circle1.GetArea()}");
            Console.WriteLine($"Omkretsen: {circle1.GetCircumference()}");
            Console.WriteLine($"Om det vore en sfär, hade den haft denna volym: {circle1.GetVolume()}");

            Console.WriteLine();

            // Same as above but radius is 6.
            Circle circle2 = new Circle(6);
            Console.WriteLine("Cirkel med radie 6:");
            Console.WriteLine($"Arean: {circle2.GetArea()}");
            Console.WriteLine($"Omkretsen: {circle2.GetCircumference()}");
            Console.WriteLine($"Om det vore en sfär, hade den haft denna volym: {circle2.GetVolume()}");

            Console.WriteLine();

            // Here is a new RightTriangle object, with height and width as inputs.
            RightTriangle triangle1 = new RightTriangle(5, 6);
            Console.WriteLine($"Triangelns höjd är 5 och basen är 6.");
            Console.WriteLine($"Hypotenusans längd = {triangle1.GetTriangleHypotenuse()}");
            Console.WriteLine($"Triangelns omkrets: {triangle1.GetTrianglePerimeter()}");
            Console.WriteLine($"Triangelns area: {triangle1.GetTriangleArea()}");
        }
    }
}
