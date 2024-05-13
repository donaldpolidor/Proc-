// Writing homework class
public class WritingAssignment : Assignment
{
    // Manufacturer
    public WritingAssignment(string studentName, string subject, string writingTopic)
        : base(studentName, subject)
    {
        WritingTopic = writingTopic;
    }

    // Additional attribute for writing subject
    private string WritingTopic { get; }

    // How to obtain writing information
    public string GetWritingInformation()
    {
        return $"{GetSummary()}\n{WritingTopic} by {_studentName}";
    }
}