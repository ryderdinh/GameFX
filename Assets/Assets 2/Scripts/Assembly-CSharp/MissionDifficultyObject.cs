using UnityEngine;

[CreateAssetMenu(fileName = "MissionDifficultyObject", menuName = "ScriptableObjects/Missions/SingleMissions/MissionDifficultyObject")]
public class MissionDifficultyObject : ScriptableObject
{
	[SerializeField]
	private MissionDifficulty _missionDifficulty;

	[SerializeField]
	private RewardObject[] _rewardObjects;

	public MissionDifficulty MissionDifficulty => default(MissionDifficulty);

	public RewardData GetMissionReward()
	{
		return default(RewardData);
	}

	public RewardObject GetMissionRewardAt(int i)
	{
		return default(RewardObject);
	}
}
