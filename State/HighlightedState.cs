using ConsoleApp.Task3.Interface;

namespace ConsoleApp.Task3.State
{
    internal class HighlightedState : IShapeState
    {
        public void Render(IRenderer renderer, string shapeName)
        {
            renderer.Render($"{shapeName} (Highlighted)");
        }
    }
}