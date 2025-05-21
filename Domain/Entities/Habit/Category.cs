namespace HabitTracker.Domain;

public class Category
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public List<HabitCategory> HabitCategories { get; set; } = new();
}