namespace ConsoleApp1
{
    static class Helper
    {
        public static T Max<T>(T a, T b) where T : System.IComparable<T>
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
    }
}
