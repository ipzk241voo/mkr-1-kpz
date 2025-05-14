using static System.Console;

namespace ConsoleApp.Task3.Visitor
{
    internal class LoggingVisitor : IShapeVisitor
    {
        public void Visit(Triangle triangle) => WriteLine($"Logged {triangle.ShapeName}");
        public void Visit(Circle circle) => WriteLine($"Logged {circle.ShapeName}");
        public void Visit(Square square) => WriteLine($"Logged {square.ShapeName}");
        public void Visit(Group group) => WriteLine($"Logged {group.ShapeName}");
    }
}