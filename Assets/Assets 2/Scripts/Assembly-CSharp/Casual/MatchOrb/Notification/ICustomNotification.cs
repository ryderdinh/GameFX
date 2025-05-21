namespace Casual.MatchOrb.Notification
{
	public interface ICustomNotification
	{
		void SendCustomNotification(NotificationId notificationId, int delayInSecs);
	}
}
