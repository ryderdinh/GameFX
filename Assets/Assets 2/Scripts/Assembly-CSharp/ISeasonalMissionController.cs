using UnityEngine;

public interface ISeasonalMissionController
{
	void ClaimSeasonalMission(int id, RewardType missionReward, int rewardAmount, int rewardSubIndex, Vector3 startPosition);

	void SeasonalMissionsCompleted();

	void UpdateCompleteAllMissionsProgress();
}
