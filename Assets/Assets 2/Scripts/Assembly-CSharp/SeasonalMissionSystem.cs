using System.Collections.Generic;
using DB;
using UnityEngine;

[CreateAssetMenu(fileName = "SeasonalMissionSystem", menuName = "ScriptableObjects/Missions/SingleMissions/SeasonalMissionSystem")]
public class SeasonalMissionSystem : BaseMissionSystem
{
	[SerializeField]
	private PreDefinedMission[] _preDefinedMissions;

	[SerializeField]
	private SeasonalMissionStage[] _seasonalMissionStages;

	[SerializeField]
	private DBInt _dbMissionIndex;

	[SerializeField]
	private int _numberOfStages;

	[SerializeField]
	private int _missionsPerStage;

	private ISeasonalMissionController _iSeasonalMissionController;

	private int _durationPerStageInSecs;

	private int _durationPerStageInDays;

	private int _numberOfDaysPassed;

	private int _unlockedStages;

	private int _missionIndex;

	private List<SeasonalMissionController> _seasonalMissionControllers;

	private ILiveOps _liveOpsHandler;

	public int NumberOfStages => 0;

	public int MissionsPerStage => 0;

	public void Initialize(ILiveOps liveOps, ISeasonalMissionController iSeasonalMissionController, Dictionary<MissionType, SingleMissionObject> seasonalMissions)
	{
	}

	public void LoadEventData(bool isFirstTime)
	{
	}

	protected override void LoadState()
	{
	}

	protected override void SaveState()
	{
	}

	private void InitializeStages(bool isFirstTime)
	{
	}

	private SeasonalMissionStage ReadStage(ref int j, int stageNumber)
	{
		return null;
	}

	private SeasonalMissionStage PopulateNewStage(int stageNumber)
	{
		return null;
	}

	private SeasonalMissionStage PopulateNewStageWithPredefinedMissions(int stageNumber)
	{
		return null;
	}

	public override void UpdateMissionProgress(MissionType missionType, int progressMade)
	{
	}

	public void ResetMissionProgress(MissionType missionType)
	{
	}

	public override void MissionClaimed(int missionId)
	{
	}

	public SeasonalMissionStage GetStageAt(int i)
	{
		return null;
	}

	public int GetNextStageUnlockingTime()
	{
		return 0;
	}

	public void SeasonalMissionCompleted()
	{
	}

	private bool AreAllStagesUnlocked()
	{
		return false;
	}

	public override void Reset()
	{
	}
}
