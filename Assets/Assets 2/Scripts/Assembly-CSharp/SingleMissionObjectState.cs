public class SingleMissionObjectState
{
	public MissionType MissionType;

	public int Id;

	public int RewardIndex;

	public MissionDifficulty MissionDifficulty;

	public int TotalAmount;

	public MissionProgressState MissionProgressState;

	private int _progress;

	public int Progress => 0;

	public SingleMissionObjectState(MissionType missionType, int totalAmount, int progress, int id, int rewardIndex, MissionDifficulty missionDifficulty, MissionProgressState missionProgressState)
	{
	}

	public void UpdateMissionProgress(int progressMade)
	{
	}

	public void ResetMissionProgress()
	{
	}

	public void MissionClaimed()
	{
	}
}
