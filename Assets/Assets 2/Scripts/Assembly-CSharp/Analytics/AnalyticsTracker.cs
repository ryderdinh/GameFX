using UnityEngine;

namespace Analytics
{
	[CreateAssetMenu(fileName = "AnalyticsTracker", menuName = "Analytics/Analytics Tracker")]
	public class AnalyticsTracker : ScriptableObject
	{
		public bool CanShowEventLogs;

		[SerializeField]
		private ScoreSystem _scoreSystem;

		[SerializeField]
		private UserJourneySystem _userJourneySystem;

		[SerializeField]
		private MetaSystem _metaSystem;

		[SerializeField]
		private LevelSystem _levelSystem;

		public string GetCurrentGameStatus()
		{
			return null;
		}

		public string GetLifetimeGameStatus()
		{
			return null;
		}

		public int GetCurrentScore()
		{
			return 0;
		}

		public int GetHighScore()
		{
			return 0;
		}

		public int GetLifeTimeInterstitialsWatchedCount()
		{
			return 0;
		}

		public int GetLifeTimeRewardedAdsWatchedCount()
		{
			return 0;
		}

		public void AddAdRevenue(double amount)
		{
		}

		public int GetCurrentCheckPoint()
		{
			return 0;
		}

		public int GetCurrentLevel()
		{
			return 0;
		}

		public int GetCurrentWorld()
		{
			return 0;
		}

		public string GetCurrentVersion()
		{
			return null;
		}

		public string GetDeviceTime()
		{
			return null;
		}
	}
}
