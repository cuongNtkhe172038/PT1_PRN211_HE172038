using System;

namespace factoriesdemo
{
    // Interface định nghĩa chung cho các hình học
    public interface IShape
    {
        void Draw();
    }

    // Các lớp cụ thể triển khai IShape
    public class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a Circle");
        }
    }

    public class Square : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a Square");
        }
    }

    // Abstract class cho Factory
    public abstract class ShapeFactory
    {
        public abstract IShape CreateShape();
    }

    // Các lớp Factory triển khai ShapeFactory
    public class CircleFactory : ShapeFactory
    {
        public override IShape CreateShape()
        {
            return new Circle();
        }
    }

    public class SquareFactory : ShapeFactory
    {
        public override IShape CreateShape()
        {
            return new Square();
        }
    }

    // Client sử dụng Factory để tạo đối tượng
    public class Client
    {
        public void DrawShape(ShapeFactory shapeFactory)
        {
            IShape shape = shapeFactory.CreateShape();
            shape.Draw();
        }
    }

    class Program
    {
        static void Main()
        {
            Client client = new Client();

            // Sử dụng CircleFactory để tạo hình tròn
            client.DrawShape(new CircleFactory());

            // Sử dụng SquareFactory để tạo hình vuông
            client.DrawShape(new SquareFactory());
        }
    }
}
