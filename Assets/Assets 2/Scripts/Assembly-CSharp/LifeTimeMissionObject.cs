using DB;
using UnityEngine;

[CreateAssetMenu(fileName = "LifeTimeMissionObject", menuName = "ScriptableObjects/Missions/LifeTimeMissionObject")]
public class LifeTimeMissionObject : MissionObject
{
	[SerializeField]
	private Milestone[] _milestones;

	[SerializeField]
	private DBInt _dbCurrentMilestone;

	private int _currentMilestone;

	public int MissionProgress => 0;

	public int NextMilestoneAmount => 0;

	public int CurrentMilestone => 0;

	public int TotalMilestones => 0;

	public override void Initialize(ILifeTimeMissionObject missionObject)
	{
	}

	public override void UpdateMissionProgress(int progressMade)
	{
	}

	public override string GetDescription()
	{
		return null;
	}

	public override string GetRewardText()
	{
		return null;
	}

	public override void ClaimMission(Vector3 startPosition)
	{
	}

	public bool IsNextMilestoneAvailable()
	{
		return false;
	}

	private Milestone CurrentMilestoneObject()
	{
		return default(Milestone);
	}
}
