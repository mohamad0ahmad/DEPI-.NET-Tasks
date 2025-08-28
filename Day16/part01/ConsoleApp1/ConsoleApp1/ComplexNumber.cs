namespace ConsoleApp1
{
    class ComplexNumber
    {
        public double Real { get; set; }
        public double Imag { get; set; }

        public ComplexNumber(double r, double i)
        {
            Real = r;
            Imag = i;
        }

        public static ComplexNumber operator *(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber(
                (c1.Real * c2.Real) - (c1.Imag * c2.Imag),
                (c1.Real * c2.Imag) + (c1.Imag * c2.Real)
            );
        }

        public override string ToString() => $"{Real} + {Imag}i";
    }
}
