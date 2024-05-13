// Basic homework class
public class Assignment
{
    // Protected member variable for student name
    protected string _studentName;
    private string _subject;

    // Manufacturer
    public Assignment(string studentName, string subject)
    {
        _studentName = studentName;
        _subject = subject;
    }

    // How to obtain the summary
    public string GetSummary()
    {
        return $"{_studentName} - {_subject}";
    }
}
