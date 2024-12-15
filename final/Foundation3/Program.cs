using System;

class Program
{
    static void Main(string[] args)
    {
        Address address = new Address("123 fake street", "Rexburg", "ID", "USA");
        
        Event myLecture = new Lecture("Intro Class", "Introduction to class", "2024-12-12", "7:00 AM", address, "Dr. John", 100);
        Event myReception = new Reception("Christmas Party", "Celebrate the holiday!", "2024-12-25", "6:00 PM", address, "rsvp@company.com");
        Event myOutdoorEvent = new Outdoor("Funrun", "Join us for a charity run!", "2025-01-01", "2:00 AM", address, "Sunny");

        Console.WriteLine(myLecture.GetAllDetails());
        Console.WriteLine(myReception.GetAllDetails());
        Console.WriteLine(myOutdoorEvent.GetAllDetails());
    }
}