using MS.Casual.IAP;
using UnityEngine;

namespace Analytics
{
	[CreateAssetMenu(fileName = "AnalyticsAdjustLogger", menuName = "Analytics/AnalyticsAdjustLogger")]
	public class AnalyticsAdjustLogger : ScriptableObject
	{
		[SerializeField]
		private AnalyticsAdjustTokens _tokens;

		public void LogLevelStepCompleteEvent(int levelId)
		{
		}

		public void InterstitialAdWatched(int count)
		{
		}

		public void RewardedVideoWatched(int count)
		{
		}

		public void LogAdRevenueEvent(string adUnitId, MaxSdkBase.AdInfo impressionData)
		{
		}

		public void LogIAPVerificationUnknown()
		{
		}

		public void LogIAPVerificationFailed()
		{
		}

		public void LogIAPVerificationInvalid()
		{
		}

		public void LogIAPVerificationValid()
		{
		}

		public void IAPPurchased(TransactionRecord product)
		{
		}

		private void LogAllSkusEvent(TransactionRecord product)
		{
		}

		private void LogIAPPurchaseEvent(TransactionRecord product)
		{
		}

		private void LogAdjustEvent(string eventId)
		{
		}
	}
}
