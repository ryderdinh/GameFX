using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "LifeTimeUserJourney", menuName = "ScriptableObjects/UserJourney/LifeTimeUserJourney")]
public class LifeTimeUserJourney : BaseUserJourney
{
	[Header("Flowers")]
	[SerializeField]
	protected List<FlowerAnalytics> _FlowerCompleteAnalytics;

	private LifeTimeUserJourneyData _journeyData;

	protected Dictionary<FlowerType, FlowerAnalytics> _FlowerAnalyticsDictionary;

	public override void Initialize()
	{
	}

	public override void MatchMade(FlowerType flowerType)
	{
	}

	public override void FlowerCardsCollected(FlowerType flowerType, FlowerCardSource cardSource, int cardsCollected)
	{
	}

	public override UserJourneyData GetUserJourneyData()
	{
		return null;
	}

	public override void TurnCompleted()
	{
	}

	private void TurnPlayed()
	{
	}

	public int GetTotalTurnsPlayed()
	{
		return 0;
	}
}
