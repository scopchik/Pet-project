using HabitTracker.Domain.ValueObjects;

namespace HabitTracker.Domain;

public class Habit
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int TargetCount { get; set; }
    public Streak CurrentStreak { get; private set; } = new Streak(0);
    public TimeSpan ReminderTime { get; set; } 
    public bool IsArchived { get; set; } 

    public Guid UserId { get; set; }
    public User? User { get; set; }

    public List<HabitRecord> Records { get; set; } = new();
    public List<HabitCategory> HabitCategories { get; set; } = new();

    public void UpdateStreak(bool isCompletedToday)
    {
        CurrentStreak = isCompletedToday 
            ? CurrentStreak.Increment() 
            : CurrentStreak.Reset();
    }
}