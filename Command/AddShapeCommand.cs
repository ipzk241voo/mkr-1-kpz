using ConsoleApp.Task3.Structure;

namespace ConsoleApp.Task3.Command
{
    internal class AddShapeCommand : ICommand
    {
        private readonly Group _group;
        private readonly Shape _shape;

        public AddShapeCommand(Group group, Shape shape)
        {
            _group = group;
            _shape = shape;
        }

        public void Execute() => _group.Add(_shape);
        public void Undo() => _group.Remove(_shape);
    }
}