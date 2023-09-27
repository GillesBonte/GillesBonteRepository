using DoorSimulationExceptionHandling;

try
{
    //Door newDoor = new Door(false, true);
    //newDoor.OpenDoor();
    Door newDoor2 = new Door(true, false);
    newDoor2.LockDoor();
}
catch (ExceptionDoorLocked ex)
{
    CustomFileLog.AddErrorLog(ex.ToString());
    Console.WriteLine(ex);
}
catch (ExceptionDoorOpened ex)
{
    CustomFileLog.AddErrorLog(ex.ToString());
    Console.WriteLine(ex);
}

Console.ReadLine();
