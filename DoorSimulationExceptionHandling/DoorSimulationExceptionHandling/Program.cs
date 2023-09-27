using DoorSimulationExceptionHandling;

try
{
    //  Door newDoor = new Door(false, true);
    //  newDoor.OpenDoor();
    Door newDoor2 = new Door(true, false);
    newDoor2.LockDoor();
}
catch (ExceptionDoorLocked ex)
{
    Console.WriteLine(ex);
    CustomFileLog.AddErrorLog(ex.ToString());
}
catch (ExceptionDoorOpened ex)
{
    Console.WriteLine(ex);
    CustomFileLog.AddErrorLog(ex.ToString());
}

Console.ReadLine();
