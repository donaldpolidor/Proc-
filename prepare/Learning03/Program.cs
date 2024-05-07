class Program
{
    static void Main(string[] args)
    {
        // Creating instances of Fraction using different constructors
        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(5);
        Fraction fraction3 = new Fraction(6, 7);

        // Displaying the fractions using GetFractionString method
        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction3.GetFractionString());

        // Displaying the decimal values using GetDecimalValue method
        Console.WriteLine(fraction1.GetDecimalValue());
        Console.WriteLine(fraction2.GetDecimalValue());
        Console.WriteLine(fraction3.GetDecimalValue());
    }
}