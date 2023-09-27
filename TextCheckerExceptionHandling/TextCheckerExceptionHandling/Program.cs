// See https://aka.ms/new-console-template for more information

using System.Reflection.Metadata.Ecma335;
using TextCheckerExceptionHandling;

try
{
    TextChecker tcText = new TextChecker("aF");
    TextChecker tcText2 = new TextChecker("a9");
    TextChecker tcText3 = new TextChecker("abcdeddghijklmnopqrstuvwxyzabcdeddghijklmnopqrstuvwxyz");
    tcText3.TextCheck();
}
catch (ContainsNumberException ex)
{
    Console.WriteLine(ex.ToString());
    CustomFileLog.AddErrorLog(ex.ToString());
    //throw new Exception("Crash in progam", ex); --> the throw happens in clsTextChecker
}
catch (ContainsLetterFException ex)
{
    Console.WriteLine(ex.ToString());
    CustomFileLog.AddErrorLog(ex.ToString());

    //throw new Exception("Crash in progam", ex); --> the throw happens in clsTextChecker
}
catch (ContainsAlotException ex)
{
    Console.WriteLine(ex.ToString());
    CustomFileLog.AddErrorLog(ex.ToString());
    //throw new Exception("Crash in progam", ex); --> the throw happens in clsTextChecker
}

Console.ReadLine();

