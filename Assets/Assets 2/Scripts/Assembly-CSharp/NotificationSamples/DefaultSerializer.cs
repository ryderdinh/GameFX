using System.Collections.Generic;

namespace NotificationSamples
{
	public class DefaultSerializer : IPendingNotificationsSerializer
	{
		private const byte Version = 0;

		private readonly string filename;

		public DefaultSerializer(string filename)
		{
		}

		public void Serialize(IList<PendingNotification> notifications)
		{
		}

		public IList<IGameNotification> Deserialize(IGameNotificationsPlatform platform)
		{
			return null;
		}
	}
}
