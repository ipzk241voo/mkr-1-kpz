using ConsoleApp.Task3.Shape;
using System.Collections.Generic;

namespace ConsoleApp.Task3.Iterator
{
    internal class DepthFirstIterator : IIterator<Shape>
    {
        private readonly Stack<Shape> _stack = new();

        public DepthFirstIterator(Shape root)
        {
            _stack.Push(root);
        }

        public bool HasNext() => _stack.Count > 0;

        public Shape Next()
        {
            var current = _stack.Pop();
            if (current is Group group)
                foreach (var child in group.GetChildren().Reverse())
                    _stack.Push(child);
            return current;
        }
    }
}