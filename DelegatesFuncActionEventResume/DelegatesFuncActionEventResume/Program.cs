internal class Program
{
    public static void Main(string[] args)
    {
        ExampleClass example = new ExampleClass();
    }
}

public class ExampleClass
{
    //To make an event with a delegate:
    //public delegate void DoSomething(int num);
    //public event DoSomething Something;

    //To make an event with an eventhandler:
    //public EventHandler Something;

    //To make an event without needing the caller or return anything
    //public Action Something;

    //To make an anonymous function immediatly assigned with a lambda
    //public Action Something = () => { };

    //To make an Action event generic
    public Action<int> Something;

    //To make an Action event generic with a return option
    //(the last type in the <> is the returned type
    public Func<int, string> Something2;


    public ExampleClass()
    {
        //With a delegate & event:
        //Something += FunctionOne;
        //Something += FunctionTwo;
        //Something?.Invoke(123);

        //With an eventhandler
        //Something(this, EventArgs.Empty);

        //With Action (anonymous function lambda)
        //Something = () => { }; 

        //With Generic Action
        Something += FunctionOne;
        Something += FunctionTwo;

        //With Generic Func
        Something2 += FuncOne;
        Something2 += FuncTwo;

    }

    private void FunctionOne(int num)
    {
        Console.WriteLine($"Function one called with value: {num}");
    }

    private void FunctionTwo(int num)
    {
        Console.WriteLine($"Function two called with value: {num}");
    }

    private string FuncOne(int num)
    {
        return $"Function one called with value: {num}";
    }
    private string FuncTwo(int num)
    {
        return $"Function two called with value: {num}";
    }


}
