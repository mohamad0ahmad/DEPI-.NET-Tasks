namespace ConsoleApp1
{
    static class Utility
    {
        public static int Perimeter(int length, int width) => 2 * (length + width);

        public static double CelsiusToFahrenheit(double c) => (c * 9 / 5) + 32;
        public static double FahrenheitToCelsius(double f) => (f - 32) * 5 / 9;
    }
}
