using DB;
using UnityEngine;

[CreateAssetMenu(fileName = "MissionObject", menuName = "ScriptableObjects/Missions/MissionObject")]
public abstract class MissionObject : ScriptableObject
{
	[SerializeField]
	protected MissionType _missionType;

	[SerializeField]
	protected string _description;

	[SerializeField]
	protected DBInt _dbMissionProgress;

	[SerializeField]
	protected DBBool _dbIsMissionClaimed;

	protected int _missionProgress;

	protected bool _isMissionClaimed;

	protected ILifeTimeMissionObject _iMissionObject;

	public MissionType MissionType => default(MissionType);

	public bool IsMissionClaimed => false;

	public virtual void Initialize(ILifeTimeMissionObject missionObject)
	{
	}

	public virtual void UpdateMissionProgress(int progressMade)
	{
	}

	public void MissionClaimed()
	{
	}

	public abstract string GetDescription();

	public abstract string GetRewardText();

	public abstract void ClaimMission(Vector3 startPosition);
}
