using HabitTracker.Domain.ValueObjects;

namespace HabitTracker.Domain;

public class User
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public Email Email { get; set; }
    public long? TelegramId { get; set; }
    public List<Habit> Habits { get; set; } = new();
    public List<UserRole> Roles { get; set; } = new();
}