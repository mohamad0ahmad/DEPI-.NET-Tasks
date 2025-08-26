using System;

namespace ConsoleApp1
{
    public class Car : IVehicle
    {
        public void StartEngine() => Console.WriteLine("Car engine started.");
        public void StopEngine() => Console.WriteLine("Car engine stopped.");
    }
}
