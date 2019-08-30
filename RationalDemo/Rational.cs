namespace RationalDemo
{
    class Rational
    {
        public int Numerator { get; private set; }
        public int Denominator { get; private set; }

        public Rational(int numerator = 0, int denominator = 1)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        public void IncreaseBy(Rational other)
        {
            if (Denominator != other.Denominator)
            {
                Numerator = (Numerator * other.Denominator) + (other.Numerator * Denominator);
                Denominator = Denominator * other.Denominator;
            }
            else
            {
                Numerator = Numerator + other.Numerator;
            }
        }

        public void DecreaseBy(Rational other)
        {
            if (Denominator != other.Denominator)
            {
                Numerator = (Numerator * other.Denominator) - (other.Numerator * Denominator);
                Denominator = Denominator * other.Denominator;
            }
            else
            {
                Numerator = Numerator - other.Numerator;
            }
        }

        public override string ToString()
        {
            // It returns an error message when the Denominator is set to 0
            if (Denominator == 0)
            {
                return $"[Invalid]";
            }
            else
            {
                return $"[{Numerator} / {Denominator}]";
            }
        }
    }
}
