public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string title, string topic, string studentName)
    : base(studentName, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        return _title;

    }
}