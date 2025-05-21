using System.Collections.Generic;
using Analytics;
using DB;
using UnityEngine;

[CreateAssetMenu(fileName = "MissionSystem", menuName = "ScriptableObjects/Missions/MissionSystem")]
public class MissionSystemController : ScriptableObject, ISeasonalMissionController, IDailyMissionController
{
	[SerializeField]
	private DailyMissionSystem _dailyMissionSystem;

	[SerializeField]
	private SeasonalMissionSystem _seasonalMissionSystem;

	[SerializeField]
	private RewardController _rewardController;

	[SerializeField]
	private SingleMissionObject[] _singleMissionObjects;

	[SerializeField]
	private DBBool _dbMissionCenterTutorialShown;

	[SerializeField]
	private int _completedMissionsToShowTutorial;

	[SerializeField]
	private AnalyticsSystem _analyticsSystem;

	private Dictionary<MissionType, SingleMissionObject> _singleMissionObjectsDictionary;

	private ILiveOps _liveOpsHandler;

	private bool _missionCenterTutorialShown;

	public SeasonalMissionSystem SeasonalMissionSystem => null;

	public void Initialize(ILiveOps liveOps)
	{
	}

	public void LoadEventData(bool isFirstTime, bool isDailyEnded = false)
	{
	}

	public List<DailyMissionController> GetDailyMissionController()
	{
		return null;
	}

	public bool IsDailyMissionEnded()
	{
		return false;
	}

	public void DailyMissionEnded()
	{
	}

	public void NewDailyMissionsLoaded()
	{
	}

	public void UpdateMissionProgress(MissionType missionType, int progressMade = 1)
	{
	}

	public void ResetMissionProgress(MissionType missionType)
	{
	}

	public int GetNumberOfMissionsCompleted()
	{
		return 0;
	}

	public int GetSeasonRemainingTime()
	{
		return 0;
	}

	public int GetNextStageUnlockingTime()
	{
		return 0;
	}

	public int GetDailyMissionsRemainingTime()
	{
		return 0;
	}

	public void TutorialShown()
	{
	}

	public bool CanShowTutorial()
	{
		return false;
	}

	void IDailyMissionController.ClaimDailyMission(int missionId, RewardType missionReward, int rewardAmount, int rewardSubIndex, Vector3 startPosition)
	{
	}

	void IDailyMissionController.UpdateCompleteAllMissionsProgress()
	{
	}

	void IDailyMissionController.DailyMissionCompleted()
	{
	}

	void ISeasonalMissionController.ClaimSeasonalMission(int id, RewardType missionReward, int rewardAmount, int rewardSubIndex, Vector3 startPosition)
	{
	}

	void ISeasonalMissionController.SeasonalMissionsCompleted()
	{
	}

	void ISeasonalMissionController.UpdateCompleteAllMissionsProgress()
	{
	}

	public void MissionCompleted()
	{
	}

	public void Reset()
	{
	}
}
