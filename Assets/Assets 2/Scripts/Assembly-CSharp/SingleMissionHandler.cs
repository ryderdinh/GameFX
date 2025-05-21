using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SingleMissionHandler", menuName = "ScriptableObjects/Missions/SingleMissions/SingleMissionHandler")]
public class SingleMissionHandler : ScriptableObject
{
	[SerializeField]
	private SingleMissionHandlerType _singleMissionHandlerType;

	[SerializeField]
	private SingleMissionTypeData[] _singleMissionTypeData;

	public SingleMissionHandlerType SingleMissionHandlerType => default(SingleMissionHandlerType);

	public SingleMissionObject GetSingleMission(List<MissionType> missions)
	{
		return null;
	}

	private int GetTotalProbability()
	{
		return 0;
	}
}
