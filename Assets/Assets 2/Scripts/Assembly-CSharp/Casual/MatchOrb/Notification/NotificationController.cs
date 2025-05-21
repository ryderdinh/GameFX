using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NotificationSamples;
using UnityEngine;

namespace Casual.MatchOrb.Notification
{
	public class NotificationController : MonoBehaviour, ICustomNotification
	{
		[CompilerGenerated]
		private sealed class _003CRequestAuthorization_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CRequestAuthorization_003Ed__23(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CShowDeliveryNotificationCoroutine_003Ed__31 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CShowDeliveryNotificationCoroutine_003Ed__31(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CIShowLocalNotificationDialog_003Ed__36 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public NotificationController _003C_003E4__this;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CIShowLocalNotificationDialog_003Ed__36(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[SerializeField]
		private List<LocalNotificationSO> _notifications;

		private DateTime _firstScheduleTime;

		private bool cancelNotificatons;

		private string[] _notificationHeaders;

		private string[] _notificationBody;

		public const string NOTIFICATION_STATUS = "NOTIFICATION_STATUS";

		public const string CUSTOM_DIALOG_STATUS = "CUSTOM_DIALOG_STATUS";

		private string _cNId;

		private string _cTitleTxt;

		private string _cBodyTxt;

		public const string ChannelId = "game_channel0";

		public const string ReminderChannelId = "reminder_channel1";

		public const string NewsChannelId = "news_channel2";

		[SerializeField]
		protected GameNotificationsManager _Manager;

		private static NotificationController _nController;

		private Coroutine coroutineNotification;

		private static NotificationController _instance => null;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnApplicationFocus(bool hasFocus)
		{
		}

		private bool CanScheduleAllNotifications()
		{
			return false;
		}

		private void ScheduleAllNotifications()
		{
		}

		public void RequestForAuthorization()
		{
		}

		[IteratorStateMachine(typeof(_003CRequestAuthorization_003Ed__23))]
		private IEnumerator RequestAuthorization()
		{
			return null;
		}

		void ICustomNotification.SendCustomNotification(NotificationId notificationId, int delayInSecs)
		{
		}

		public void SendNotification(LocalNotificationSO localNotification, NotificationText notificationText)
		{
		}

		private void SendNotification(string title, string body, DateTime deliveryTime, string group, int? badgeNumber = null, bool reschedule = false, string channelId = null, string smallIcon = null, string largeIcon = null)
		{
		}

		private LocalNotificationSO GetNotifictionFromId(NotificationId notificationId)
		{
			return null;
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDelivered(PendingNotification deliveredNotification)
		{
		}

		[IteratorStateMachine(typeof(_003CShowDeliveryNotificationCoroutine_003Ed__31))]
		private IEnumerator ShowDeliveryNotificationCoroutine(IGameNotification gameNotification)
		{
			return null;
		}

		private void OnExpired(PendingNotification obj)
		{
		}

		private void LoadStatus()
		{
		}

		public void ShowLocalNotificationDialog()
		{
		}

		[IteratorStateMachine(typeof(_003CIShowLocalNotificationDialog_003Ed__36))]
		private IEnumerator IShowLocalNotificationDialog()
		{
			return null;
		}
	}
}
