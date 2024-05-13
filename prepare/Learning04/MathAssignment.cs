// Math homework class
public class MathAssignment : Assignment
{
    // Manufacturer
    public MathAssignment(string studentName, string subject, string assignmentDetails)
        : base(studentName, subject)
    {
        AssignmentDetails = assignmentDetails;
    }

    // Additional attribute for math assignment details
    private string AssignmentDetails { get; }

    // How to obtain the list of mathematics assignments
    public string GetHomeworkList()
    {
        return $"{GetSummary()}\n{AssignmentDetails}";
    }
}