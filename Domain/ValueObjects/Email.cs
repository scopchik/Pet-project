using System.Text.RegularExpressions;

namespace HabitTracker.Domain.ValueObjects;

public record Email
{
    public string Value { get; }

    public Email(string value)
    {
        if (!IsValid(value)) throw new ArgumentException("Invalid email.");
        Value = value;
    }

    private static bool IsValid(string email) 
        => Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
}