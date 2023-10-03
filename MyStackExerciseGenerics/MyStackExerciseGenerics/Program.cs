

using MyStackExerciseGenerics;

MyStack<int> nieuweStack = new MyStack<int>();

nieuweStack.Add(1);
nieuweStack.Add(2);
nieuweStack.Add(3);
nieuweStack.Add(4);
nieuweStack.Add(5);   
nieuweStack.Add(6);
nieuweStack.Add(7);
nieuweStack.Add(8);
nieuweStack.Add(9);
nieuweStack.Add(10);
try
{
    Console.WriteLine(nieuweStack.Peek());
    Console.WriteLine(nieuweStack.Remove());
    Console.WriteLine(nieuweStack.Remove());
    Console.WriteLine(nieuweStack.Remove());
    Console.WriteLine(nieuweStack.Remove());
    Console.WriteLine(nieuweStack.Remove());
    Console.WriteLine(nieuweStack.Remove());
    Console.WriteLine(nieuweStack.Remove());
    Console.WriteLine(nieuweStack.Remove());
    Console.WriteLine(nieuweStack.Remove());
    Console.WriteLine(nieuweStack.Remove());
    Console.WriteLine(nieuweStack.Remove());
    Console.WriteLine(nieuweStack.Remove());
    Console.WriteLine(nieuweStack.Remove());
    Console.WriteLine(nieuweStack.Remove());
}
catch (InvalidOperationException ex)
{

    Console.WriteLine("Stack is empty");
}


Console.ReadLine();
