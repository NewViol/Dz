class Complex
{
    double A;
    double B;

    public Complex(double a = 1, double b = 3)
    {
        A = a;
        B = b;
    }

    public static Complex operator +(Complex a, Complex b)
    {
        return new Complex(a.A + b.A, a.B + b.B);
    }
    public static Complex operator -(Complex a, Complex b)
    {
        return new Complex(a.A - b.A, a.B - b.B);
    }

    public static Complex operator *(Complex a, Complex b)
    {
        return new Complex(a.A * b.A - a.B * b.B, a.B * b.A + a.A * b.B);
    }
    public static Complex operator /(Complex a, Complex b)
    {
        return new Complex((a.A * b.A + a.B * b.B) / (b.A * b.A + b.B * b.B), (a.B * b.A - a.A * b.B) / (b.A * b.A + b.B * b.B));
    }
    public override string ToString()
    {
        if (B < 0)
        {
            return $"{A}{B}i";
        }
        return $"{A}+{B}i";
    }
}
