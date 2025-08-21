using ConsoleApp1;

namespace ConsoleApp1
{
    class File : IReadable, IWritable
    {
        public void Read() => System.Console.WriteLine("Reading file...");
        public void Write() => System.Console.WriteLine("Writing file...");
    }
}
