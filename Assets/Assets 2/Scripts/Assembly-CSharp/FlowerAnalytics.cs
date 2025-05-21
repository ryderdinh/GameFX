using DB;
using UnityEngine;

[CreateAssetMenu(fileName = "FlowerAnalytics", menuName = "ScriptableObjects/UserJourney/FlowerAnalytics", order = 1)]
public class FlowerAnalytics : ScriptableObject
{
	[SerializeField]
	private FlowerType _flowerType;

	[SerializeField]
	private ItemSystem _itemSystem;

	[SerializeField]
	private DBString _flowerJourneyData;

	[SerializeField]
	private string[] _variablesToPort;

	private FlowerAnalyticsData _analyticsData;

	public FlowerType FlowerType => default(FlowerType);

	private void OnEnable()
	{
	}

	public void FlowersMerged()
	{
	}

	public void FlowerCardsCollected(FlowerCardSource cardSource, int amount)
	{
	}

	public void ResetFlowersAnalyticData()
	{
	}

	public FlowerAnalyticsData GetFlowerAnalyticsData()
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
