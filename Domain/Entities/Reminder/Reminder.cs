namespace HabitTracker.Domain.Entities.Reminder;

public class Reminder
{
    public Guid Id { get; set; }
    public TimeSpan Time { get; set; } // Время напоминания
    public bool IsEnabled { get; set; }

    public Guid HabitId { get; set; }
    public Habit Habit { get; set; }
}