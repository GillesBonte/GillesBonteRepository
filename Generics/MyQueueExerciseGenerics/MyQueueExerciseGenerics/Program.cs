using MyQueueExerciseGenerics;

MyQueue<int> queueOfInts = new MyQueue<int>();

queueOfInts.Add(1);
queueOfInts.Add(2);
queueOfInts.Add(3);
queueOfInts.Add(4);
queueOfInts.Add(5);
queueOfInts.Add(6);

Console.WriteLine(queueOfInts.Peek());
try
{
    
    Console.WriteLine("returned: " + queueOfInts.Remove());
    Console.WriteLine(queueOfInts.Peek());
    Console.WriteLine("returned: " + queueOfInts.Remove());
    Console.WriteLine(queueOfInts.Peek());
    Console.WriteLine("returned: " + queueOfInts.Remove());
    Console.WriteLine(queueOfInts.Peek());
    Console.WriteLine("returned: " + queueOfInts.Remove());
    Console.WriteLine(queueOfInts.Peek());
    Console.WriteLine("returned: " + queueOfInts.Remove());
    Console.WriteLine(queueOfInts.Peek());
    Console.WriteLine("returned: " + queueOfInts.Remove());
    Console.WriteLine(queueOfInts.Peek());
    Console.WriteLine("returned: " + queueOfInts.Remove());
    Console.WriteLine(queueOfInts.Peek());
    Console.WriteLine("returned: " + queueOfInts.Remove());
    Console.WriteLine(queueOfInts.Peek());

}
catch (Exception ex)
{
    Console.WriteLine(ex);
}
