using UnityEngine;

[CreateAssetMenu(fileName = "TurnBaseUserJourney", menuName = "ScriptableObjects/UserJourney/TurnBaseUserJourney")]
public class TurnBaseUserJourney : BaseUserJourney
{
	private TurnBaseUserJourneyData _journeyData;

	public override void Initialize()
	{
	}

	public override UserJourneyData GetUserJourneyData()
	{
		return null;
	}

	public override void TurnCompleted()
	{
	}

	private void ResetJourney()
	{
	}
}
