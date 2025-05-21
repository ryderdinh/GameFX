using System.Collections.Generic;
using Helpshift;

public class HelpShiftEventListener : IHelpshiftEventsListener
{
	public static int MessageCount;

	void IHelpshiftEventsListener.AuthenticationFailedForUser(HelpshiftAuthenticationFailureReason reason)
	{
	}

	void IHelpshiftEventsListener.HandleHelpshiftEvent(string eventName, Dictionary<string, object> eventData)
	{
	}

	private void UpdateUnreadMessagesCount(object msgCount)
	{
	}
}
