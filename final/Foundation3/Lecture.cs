class Lecture : Event
{
    private string _speaker;
    private int _limit;

    public Lecture(string title, string description, string date, string time, Address address, string speaker, int limit)
        : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _limit = limit;
    }

    public override string GetAllDetails()
    {
        return base.GetAllDetails() + $" Speaker: {_speaker}. Capacity: {_limit} people.";
    }
}

