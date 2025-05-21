using UnityEngine;

[CreateAssetMenu(fileName = "SingleMissionObject", menuName = "ScriptableObjects/Missions/SingleMissions/SingleMissionObject")]
public class SingleMissionObject : ScriptableObject
{
	[SerializeField]
	protected MissionType _missionType;

	[SerializeField]
	protected string _descriptionForSingle;

	[SerializeField]
	protected string _descriptionForMultiple;

	[SerializeField]
	private MissionDifficultyData[] _missionDifficultyData;

	[SerializeField]
	private int _probability;

	[SerializeField]
	private Sprite _missionIcon;

	public MissionType MissionType => default(MissionType);

	public int Probability => 0;

	public Sprite MissionIcon => null;

	public MissionDifficultyData GetMissionData()
	{
		return default(MissionDifficultyData);
	}

	private int GetTotalProbability()
	{
		return 0;
	}

	public string GetDescriptionForSingle()
	{
		return null;
	}

	public string GetDescriptionForMultiple()
	{
		return null;
	}
}
