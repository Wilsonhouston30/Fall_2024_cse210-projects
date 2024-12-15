class Reception : Event
{
    private string _rsvpEmail;

    public Reception(string title, string description, string date, string time, Address address, string rsvpEmail)
        : base(title, description, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
    }

    public override string GetAllDetails()
    {
        return base.GetAllDetails() + $" RSVP at: {_rsvpEmail}.";
    }
}