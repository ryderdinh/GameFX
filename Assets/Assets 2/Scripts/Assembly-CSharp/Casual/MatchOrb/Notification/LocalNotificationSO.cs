using System.Collections.Generic;
using UnityEngine;

namespace Casual.MatchOrb.Notification
{
	[CreateAssetMenu]
	public class LocalNotificationSO : ScriptableObject
	{
		[Header("Configurations")]
		public NotificationId NotificationID;

		public TriggerType TriggerType;

		public int TriggerTimeInSecs;

		public LocalNotificationSO(NotificationId id, TriggerType type, int time, List<NotificationText> texts)
		{
		}
	}
}
