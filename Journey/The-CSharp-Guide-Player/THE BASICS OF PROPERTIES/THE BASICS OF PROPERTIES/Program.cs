namespace THE_BASICS_OF_PROPERTIES
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        public class Rectangle
        {
            private float _width;
            private float _height;
            public Rectangle(float width, float height)
            {
                _width = width;
                _height = height;
            }
            public float GetWidth() => _width;
            public float GetHeight() => _height;
            public float GetArea() => _width * _height;
            public void SetWidth(float value) => _width = value;
            public void SetHeight(float value) => _height = value;
        }
    }
}
