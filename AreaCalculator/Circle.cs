namespace AreaCalculator
{
    public class Circle
    {
        public int Radius;

        public Circle(int radius)
        {
            Radius = radius;
        }

        public float GetArea()
        {
            return Radius * Radius * MathF.PI;
        }

        public float GetPerimeter()
        {
            return 2 * MathF.PI * Radius;
        }
    }
}
