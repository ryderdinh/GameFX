using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SeasonalMissionStage", menuName = "ScriptableObjects/Missions/SingleMissions/SeasonalMissionStage")]
public class SeasonalMissionStage : ScriptableObject
{
	[SerializeField]
	private SingleMissionHandlerData[] _singleMissionHandlerData;

	private int _id;

	private bool _isUnlocked;

	private List<SeasonalMissionController> _seasonalMissionControllers;

	private List<SingleMissionObjectState> _seasonalMissionObjectStates;

	public int ID => 0;

	public bool IsUnlocked => false;

	public void Initialize(bool isUnlocked, int id)
	{
	}

	public SeasonalMissionController GetMissionControllerAt(int i)
	{
		return null;
	}

	public void AddMission(SeasonalMissionController seasonalMissionController, SingleMissionObjectState singleMissionObjectState)
	{
	}

	public int NumberOfMissionsToGetFromHandler(SingleMissionHandlerType type)
	{
		return 0;
	}
}
