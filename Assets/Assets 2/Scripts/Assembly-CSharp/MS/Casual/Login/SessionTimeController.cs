using MSKit.Database;

namespace MS.Casual.Login
{
	public class SessionTimeController
	{
		private readonly DatabaseTimeState _sessionTimeState;

		private double _timeToReset;

		public SessionTimeController(string timeKey, double timeToReset)
		{
		}

		public bool IsTimeCompleted(bool updateCurrentTime = true)
		{
			return false;
		}

		public void SaveCurrentTime()
		{
		}

		public double GetRemainingTime()
		{
			return 0.0;
		}
	}
}
