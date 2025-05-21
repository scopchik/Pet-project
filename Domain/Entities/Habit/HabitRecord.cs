namespace HabitTracker.Domain;

public class HabitRecord
{
    public Guid Id { get; set; }
    public DateTime Date { get; set; }
    public bool IsCompleted { get; set; }
    public string? Notes { get; set; }

    public Guid HabitId { get; set; }
    public Habit Habit { get; set; }
}