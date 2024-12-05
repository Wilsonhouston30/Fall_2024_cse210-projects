public class MathAssignments : Assignments
{
    private string _textTextSection;
    private string _problems;


    public MathAssignments (string textTextSection, string Problem, string studentName, string topic) : base(studentName, topic)
    {
        _textTextSection = textTextSection;
        _problems = Problem;
    }

    public string GetHomeworkList()
    {
        return $"Section {_textTextSection} Problems {_problems}";
    }
}