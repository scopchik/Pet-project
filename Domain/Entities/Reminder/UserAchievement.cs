namespace HabitTracker.Domain.Entities.Reminder;

public class UserAchievement
{
    public Guid UserId { get; set; }
    public User User { get; set; }

    public Guid AchievementId { get; set; }
    public Achievement Achievement { get; set; }

    public DateTime UnlockedAt { get; set; }
}