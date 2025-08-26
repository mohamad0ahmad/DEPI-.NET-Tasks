using System;

namespace ConsoleApp1
{
    public class Robot : IWalkable
    {
        public void Walk()
        {
            Console.WriteLine("Robot walking (own method).");
        }

        void IWalkable.Walk()
        {
            Console.WriteLine("Robot walking (IWalkable method).");
        }
    }
}
