namespace AreaCalculator
{
    public  class Program
    {
        static void Main(string[] args)
        {
            var rectangle = new Rectangle(10, 5);

            Console.WriteLine($"Rectangle with {rectangle.Width}x{rectangle.Height} dimenssions.");
            Console.WriteLine($"Rectangle area: {rectangle.GetArea()}cm");
            Console.WriteLine($"Rectangle perimeter: {rectangle.GetPerimeter()}cm");

            var circle = new Circle(10);
            Console.WriteLine($"Circle with {circle.Radius}cm of radius");
            Console.WriteLine($"Circle area: {circle.GetArea()}");
            Console.WriteLine($"Circle perimeter: {circle.GetPerimeter()}cm");
        }
    }
}