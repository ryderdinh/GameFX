using UnityEngine;

[CreateAssetMenu(fileName = "BoosterAnalytics", menuName = "ScriptableObjects/UserJourney/BoosterAnalytics", order = 1)]
public class BoosterAnalytics : ScriptableObject
{
	[SerializeField]
	private BoostersUsageData[] _boostersData;

	private BoosterAnalyticsData _analyticsData;

	private void OnEnable()
	{
	}

	public void BoosterOffered(BoostersTypes boosterType)
	{
	}

	public void BoosterAvailed(BoostersTypes boosterType)
	{
	}

	public void ResetAnalyticData()
	{
	}

	public BoosterAnalyticsData GetAnalyticsData()
	{
		return null;
	}
}
