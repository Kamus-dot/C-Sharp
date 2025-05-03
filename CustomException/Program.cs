using CustomException;

Console.WriteLine("*******Fun With Custom Exception*******");
Car mycar = new Car("Rusty", 90);
try 
{
    mycar.Accelerate(50);
}
catch (CarIsDeadException e)
{
    Console.WriteLine(e.Message);
    Console.WriteLine(e.ErrorTimeStamp);
    Console.WriteLine(e.CauseOfError);
}