using ExOef1LoggerLogic;

Logger logger = Logger.GetInstance;
Console.WriteLine("Enter Message To Log:");
string toLog = Console.ReadLine();
logger.Log(toLog);





