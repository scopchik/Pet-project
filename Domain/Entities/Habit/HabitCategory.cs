namespace HabitTracker.Domain;

public class HabitCategory
{
    public Guid HabitId { get; set; }
    public Habit Habit { get; set; }

    public Guid CategoryId { get; set; }
    public Category Category { get; set; }
}