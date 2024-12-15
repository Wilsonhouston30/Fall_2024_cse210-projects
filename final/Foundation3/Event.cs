class Event
{
    protected string _title;
    protected string _discription;
    protected string _date;
    protected string _time;
    protected Address _address;

    public Event(string title, string discription, string date, string time, Address address)
    {
        _title = title;
        _discription = discription;
        _date = date;
        _time = time;
        _address = address;
    }

    public virtual string GetDetails()
    {
        return $"{_title} on {_date} at {_time} at {_address.ToString()}";
    }

    public virtual string GetAllDetails()
    {
        return $"{_title}: {_discription} on {_date} at {_time}. Location: {_address.ToString()}";
    }

    public virtual string GetSummary()
    {
        return $"{_title} on {_date}";
    }
}