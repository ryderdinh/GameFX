using System;

[Serializable]
public struct Milestone
{
	public int MilestoneAmount;

	public RewardType MissionReward;

	public int RewardAmount;

	public bool IsMileStoneReached(int progressMade)
	{
		return false;
	}
}
