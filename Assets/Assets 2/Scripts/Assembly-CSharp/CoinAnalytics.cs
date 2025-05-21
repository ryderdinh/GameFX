using DB;
using UnityEngine;

[CreateAssetMenu(fileName = "CoinAnalytics", menuName = "ScriptableObjects/UserJourney/CoinAnalytics", order = 1)]
public class CoinAnalytics : ScriptableObject
{
	[SerializeField]
	private CashObject _cashObject;

	[SerializeField]
	private DBString _coinsJourneyData;

	[SerializeField]
	private string[] _variablesToPort;

	private CoinAnalyticsData _analyticsData;

	private void OnEnable()
	{
	}

	public void CoinsEarned(CoinSource source, int amount)
	{
	}

	public void CoinsSink(CoinSink sink, int amount)
	{
	}

	public void ResetCoinAnalyticsData()
	{
	}

	public CoinAnalyticsData GetCoinAnalyticsData()
	{
		return null;
	}

	private void LoadData()
	{
	}

	private void SaveData()
	{
	}

	private void PortVariables()
	{
	}
}
