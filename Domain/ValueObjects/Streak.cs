namespace HabitTracker.Domain.ValueObjects;

public record Streak
{
    public int Value { get; }

    public Streak(int value)
    {
        if (value < 0) throw new ArgumentException("Streak cannot be negative.");
        Value = value;
    }
    
    public Streak Reset() => new Streak(0);
    public Streak Increment() => new Streak(Value + 1);
}