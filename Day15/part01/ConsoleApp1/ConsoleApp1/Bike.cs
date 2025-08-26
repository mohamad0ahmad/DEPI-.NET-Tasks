using System;

namespace ConsoleApp1
{
    public class Bike : IVehicle
    {
        public void StartEngine() => Console.WriteLine("Bike started.");
        public void StopEngine() => Console.WriteLine("Bike stopped.");
    }
}
