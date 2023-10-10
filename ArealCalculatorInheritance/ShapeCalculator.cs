namespace ArealCalculatorInheritance
{
    public class ShapeCalculator
    {
        public double GetArea(Shape shape)
        {
            return shape.CalculateArea();
        }

        public double GetPerimeter(Shape shape)
        {
            return shape.CalculatePerimeter();
        }
    }
}
