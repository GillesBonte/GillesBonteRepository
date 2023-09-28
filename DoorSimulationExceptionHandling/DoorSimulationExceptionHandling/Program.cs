using DoorSimulationExceptionHandling;

try
{
    //Door newDoor = new Door(false, true);
    //newDoor.OpenDoor();
    //Door newDoor2 = new Door(true, false);
    //newDoor2.LockDoor();
    //Door newDoor3 = new Door(true, false);
    //newDoor3.OpenDoor();
    Door newDoor4 = new Door(false, true);
    newDoor4.LockDoor();
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
catch (ExceptionDoorAlreadyOpen ex)
{
    CustomFileLog.AddErrorLog(ex.ToString());
    Console.WriteLine(ex);
}
catch (ExceptionDoorAlreadyLocked ex)
{
    CustomFileLog.AddErrorLog(ex.ToString());
    Console.WriteLine(ex);
}
catch (Exception ex)
{
    CustomFileLog.AddErrorLog(ex.ToString());
    Console.WriteLine(ex);
}

Console.ReadLine();
