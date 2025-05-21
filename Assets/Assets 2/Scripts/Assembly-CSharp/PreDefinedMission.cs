using System;

[Serializable]
public struct PreDefinedMission
{
	public MissionType MissionType;

	public bool IsFixedDDifficulty;

	public MissionDifficultyData MissionDifficultyData;

	public int RewardIndex;
}
