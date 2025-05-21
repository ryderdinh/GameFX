using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SingleMissionTypeData", menuName = "ScriptableObjects/Missions/SingleMissions/SingleMissionTypeData")]
public class SingleMissionTypeData : ScriptableObject
{
	[SerializeField]
	private SingleMissionType _singleMissionType;

	[SerializeField]
	private int _probability;

	[SerializeField]
	private SingleMissionObject[] _singleMissionObject;

	public int Probability => 0;

	public SingleMissionObject GetSingleMission(List<MissionType> missions)
	{
		return null;
	}

	private int GetTotalProbability(List<MissionType> missions)
	{
		return 0;
	}
}
