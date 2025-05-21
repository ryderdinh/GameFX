using UnityEngine;

public interface ILifeTimeMissionObject
{
	void ClaimLifeTimeMission(RewardType missionReward, int rewardAmount, Vector3 startPosition);
}
