using System.Collections.Generic;
using DB;
using UnityEngine;

public abstract class BaseMissionSystem : ScriptableObject
{
	[SerializeField]
	protected DBString _DbMissionStates;

	[SerializeField]
	protected SingleMissionHandler[] _MissionHandlers;

	[SerializeField]
	protected MissionDifficultyObject[] _MissionDifficultyObjects;

	protected Dictionary<MissionType, SingleMissionObject> _AllMissionObjects;

	protected List<SingleMissionObjectState> _MissionObjectStates;

	protected abstract void LoadState();

	protected abstract void SaveState();

	public abstract void UpdateMissionProgress(MissionType missionType, int progressMade);

	public abstract void MissionClaimed(int missionId);

	public abstract void Reset();

	public MissionType GetMissionType(int id)
	{
		return default(MissionType);
	}

	public virtual int GetNumberOfMissionsCompleted()
	{
		return 0;
	}

	protected RewardData GetReward(MissionDifficulty missionDifficulty)
	{
		return default(RewardData);
	}

	protected RewardObject GetReward(int index, MissionDifficulty missionDifficulty)
	{
		return default(RewardObject);
	}

	protected SingleMissionObject GetMissionObjectOfType(MissionType missionType)
	{
		return null;
	}
}
