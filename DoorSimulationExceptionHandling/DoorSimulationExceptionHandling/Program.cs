using DoorSimulationExceptionHandling;

try
{
    Door newDoor = new Door(false, true);
    newDoor.OpenDoor();
}
catch (ExceptionDoorLocked ex)
{
    Console.WriteLine(ex);
    CustomFileLog.AddErrorLog(ex.ToString());
}

Console.ReadLine();
