using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PassiveMissionSystem", menuName = "ScriptableObjects/Missions/MissionSystem/PassiveMissionSystem")]
public class LifeTimeMissionSystem : ScriptableObject
{
	[SerializeField]
	private LifeTimeMissionObject[] _missionObjects;

	private Dictionary<MissionType, LifeTimeMissionObject> _missionObjectsDictionary;

	public Dictionary<MissionType, LifeTimeMissionObject> MissionObjectsDictionary => null;

	public void Initialize(ILifeTimeMissionObject missionObject)
	{
	}

	public void UpdateMissionState(MissionType missionType, int progressMade)
	{
	}
}
