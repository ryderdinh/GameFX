using UnityEngine;

public abstract class SingleMissionController
{
	protected SingleMissionObjectState _SingleMissionObjectState;

	protected SingleMissionObject _SingleMissionObject;

	protected RewardObject _RewardObject;

	public SingleMissionObject SingleMissionObject => null;

	public MissionType MissionType => default(MissionType);

	public int MissionID => 0;

	public bool IsMissionClaimed => false;

	public int Progress => 0;

	public int TotalAmount => 0;

	public Sprite MissionIcon => null;

	public RewardObject RewardObject => default(RewardObject);

	public SingleMissionController(SingleMissionObject singleMissionObject, SingleMissionObjectState singleMissionObjectState, RewardObject rewardObject)
	{
	}

	public void MissionClaimed()
	{
	}

	public bool IsMissionCompleted()
	{
		return false;
	}

	public bool IsMissionInprogress()
	{
		return false;
	}

	public abstract void UpdateMissionProgress(int progressMade);

	public string GetDescription()
	{
		return null;
	}
}
