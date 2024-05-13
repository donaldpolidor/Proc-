class Program
{
    static void Main(string[] args)
    {
        // Test de la classe de base Assignment
        Assignment assignment = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(assignment.GetSummary());

        // Test de la classe MathAssignment
        MathAssignment mathAssignment = new MathAssignment("Roberto Rodriguez", "Fractions", "Section 7.3 Problems 8-19");
        Console.WriteLine(mathAssignment.GetHomeworkList());

        // Test de la classe WritingAssignment
        WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}