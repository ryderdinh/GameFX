using UnityEngine;

public interface IDailyMissionController
{
	void ClaimDailyMission(int missionId, RewardType missionReward, int rewardAmount, int rewardSubIndex, Vector3 startPosition);

	void UpdateCompleteAllMissionsProgress();

	void DailyMissionCompleted();
}
