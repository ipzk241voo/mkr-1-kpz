using ConsoleApp.Task3.Shape;
using System.Collections.Generic;

namespace ConsoleApp.Task3.Structure
{
    internal class Group : Shape
    {
        private readonly List<Shape> _children = new();

        public Group(IRenderer renderer) : base(renderer) { }

        public void Add(Shape shape)
        {
            _children.Add(shape);
            shape.OnInserted();
        }

        public void Remove(Shape shape)
        {
            _children.Remove(shape);
            shape.OnRemoved();
        }

        public override string ShapeName => "Group";

        public override void Draw()
        {
            Renderer.Render("Group");
            foreach (var child in _children)
                child.Draw();
        }
    }
}