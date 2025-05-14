using ConsoleApp.Task3.Interface;
using ConsoleApp.Task3.Render;
using ConsoleApp.Task3.Shape;

using ConsoleApp.Task3.Structure;
using ConsoleApp.Task3.Iterator;
using ConsoleApp.Task3.Command;
using ConsoleApp.Task3.State;
using ConsoleApp.Task3.Visitor;

IRenderer raster = new RasterRenderer();
IRenderer vector = new VectorRenderer();

// 1. Шаблонний метод: OnCreated() викликається автоматично
Shape triangle = new Triangle(raster);
Shape circle = new Cricle(vector);
Shape square = new Square(raster);

WriteLine("=== Створення фігур ===");

triangle.Draw(); 
circle.Draw();   
square.Draw();

// 2. Компоновщик: група фігур (як документ)
Group document = new Group(raster);


// 3. Команда: додавання фігур з можливістю відміни
CommandManager commandManager = new CommandManager();
commandManager.Execute(new AddShapeCommand(document, triangle));
commandManager.Execute(new AddShapeCommand(document, circle));
commandManager.Execute(new AddShapeCommand(document, square));

// 4. Стан: зміна відображення
square.CurrentState = new HighlightedState();


// 5. Ітератор: обхід документу в глибину 
WriteLine("\n=== Обхід документу ===");
IIterator<Shape> dfsIterator = new DepthFirstIterator(document);
while (dfsIterator.HasNext())
{
    var element = dfsIterator.Next();
    element.Draw(); // Виводиться з урахуванням стану
}

// 6. Відвідувач: логування всіх елементів
WriteLine("\n=== Логування фігур ===");
LoggingVisitor logger = new LoggingVisitor();
document.Accept(logger);

WriteLine("\n=== Відміна додавання ===");
commandManager.Undo();

// Перевірка видалення
WriteLine("\n=== Документ після відміни ===");
document.Draw();