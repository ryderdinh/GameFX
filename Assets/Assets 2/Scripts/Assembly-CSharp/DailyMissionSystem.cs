using System.Collections.Generic;
using DB;
using UnityEngine;

[CreateAssetMenu(fileName = "DailyMissionSystem", menuName = "ScriptableObjects/Missions/SingleMissions/DailyMissionSystem")]
public class DailyMissionSystem : BaseMissionSystem
{
	[SerializeField]
	private DBInt _dbMissionIndex;

	[SerializeField]
	private PreDefinedMission[] _preDefinedMissions;

	[SerializeField]
	private SingleMissionObject[] _compulsoryMissions;

	[SerializeField]
	private int _numberOfDailyMissions;

	[SerializeField]
	private int _dailyMissionsDurationInSecs;

	private List<DailyMissionController> _dailyMissionControllers;

	private int _missionIndex;

	private bool _isDailyMissionEnded;

	private IDailyMissionController _iDailyMissionController;

	private ILiveOps _liveOpsHandler;

	public List<DailyMissionController> DailyMissionControllers => null;

	public void Initialize(ILiveOps liveOps, IDailyMissionController iDailyMissionController, Dictionary<MissionType, SingleMissionObject> dailyMissionObjects)
	{
	}

	public void LoadEventData(bool isFirstTime, bool isDailyEnded = false)
	{
	}

	private void ReadStage()
	{
	}

	protected override void LoadState()
	{
	}

	protected override void SaveState()
	{
	}

	public bool IsDailyMissionUpdated(bool isFirstTime)
	{
		return false;
	}

	public List<DailyMissionController> GetDailyMissions(bool isFirstTime)
	{
		return null;
	}

	private void ResetMissions()
	{
	}

	private void PopulatePredefinedMissions()
	{
	}

	private void PopulateMissions()
	{
	}

	public override void UpdateMissionProgress(MissionType missionType, int progressMade)
	{
	}

	public void ResetMissionProgress(MissionType missionType)
	{
	}

	public void DailyMissionCompleted()
	{
	}

	public override void MissionClaimed(int missionId)
	{
	}

	public override void Reset()
	{
	}

	public void DailyMissionEnded()
	{
	}

	public bool IsDailyMissionEnded()
	{
		return false;
	}

	public void NewDailyMissionsLoaded()
	{
	}
}
