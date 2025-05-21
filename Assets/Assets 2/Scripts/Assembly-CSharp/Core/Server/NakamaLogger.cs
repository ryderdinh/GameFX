using Nakama;

namespace Core.Server
{
	public class NakamaLogger : ILogger
	{
		private bool _enableLogging;

		public NakamaLogger(bool enableLogging)
		{
		}

		public void DebugFormat(string format, params object[] args)
		{
		}

		public void ErrorFormat(string format, params object[] args)
		{
		}

		public void InfoFormat(string format, params object[] args)
		{
		}

		public void WarnFormat(string format, params object[] args)
		{
		}
	}
}
