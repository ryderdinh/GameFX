using UnityEngine;

public class DailyMissionController : SingleMissionController
{
	private IDailyMissionController _iDailyMissionController;

	public DailyMissionController(IDailyMissionController iDailyMissionController, SingleMissionObject singleMissionObject, SingleMissionObjectState singleMissionObjectState, RewardObject rewardObject)
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
