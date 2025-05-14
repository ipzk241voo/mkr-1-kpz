using ConsoleApp.Task3.Interface;
namespace ConsoleApp.Task3.Shape
{
    internal abstract class Shape
    {
        protected IRenderer Renderer;

        public Shape(IRenderer Renderer)
        {
            this.Renderer = Renderer;
            OnCreated();
        }


        protected virtual void OnCreated() => WriteLine($"{GetType().Name} created");
        public virtual void OnInserted() => WriteLine($"{GetType().Name} inserted into document");
        public virtual void OnRemoved() => WriteLine($"{GetType().Name} removed from document");
        public abstract void Draw();
    }
}
