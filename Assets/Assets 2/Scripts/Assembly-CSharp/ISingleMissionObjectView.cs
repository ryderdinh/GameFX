using UnityEngine;

public interface ISingleMissionObjectView
{
	void ClaimDailyMission(RewardType missionReward, int rewardAmount, Vector3 startPosition);
}
