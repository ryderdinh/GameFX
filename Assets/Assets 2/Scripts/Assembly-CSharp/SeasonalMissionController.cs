using UnityEngine;

public class SeasonalMissionController : SingleMissionController
{
	private ISeasonalMissionController _iSeasonalMissionController;

	public SeasonalMissionController(ISeasonalMissionController iSeasonalMissionController, SingleMissionObject singleMissionObject, SingleMissionObjectState singleMissionObjectState, RewardObject rewardObject)
		: base(null, null, default(RewardObject))
	{
	}

	public void ClaimMission(Vector3 startPosition, int id)
	{
	}

	public override void UpdateMissionProgress(int progressMade)
	{
	}

	public void ResetMissionProgress()
	{
	}
}
