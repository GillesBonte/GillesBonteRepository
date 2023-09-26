// See https://aka.ms/new-console-template for more information

using TextCheckerExceptionHandling;

try
{
    TextChecker tcText = new TextChecker("aF");
    TextChecker tcText2 = new TextChecker("a9");
    TextChecker tcText3 = new TextChecker("abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyz");
}
catch (ContainsNumberException ex)
{
    Console.WriteLine(ex.ToString());
    throw new Exception("Crash in progam", ex);
}
catch (ContainsLetterFException ex)
{
    Console.WriteLine(ex.ToString());
    throw new Exception("Crash in progam", ex);
}
catch (ContainsAlotException ex)
{
    Console.WriteLine(ex.ToString());
    throw new Exception("Crash in progam", ex);
}

