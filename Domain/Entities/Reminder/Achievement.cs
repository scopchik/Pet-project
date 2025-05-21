namespace HabitTracker.Domain.Entities.Reminder;

public class Achievement
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string BadgeImageUrl { get; set; }

    public List<UserAchievement> UserAchievements { get; set; } = new();
}