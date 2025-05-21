using System.Collections.Generic;
using DB;
using UnityEngine;

[CreateAssetMenu(fileName = "ExperienceSystem", menuName = "ScriptableObjects/ExperienceSystem")]
public class ExperienceSystem : ScriptableObject
{
	[SerializeField]
	private DBInt DbCurrentLevel;

	[SerializeField]
	private int _perMergeExp;

	[SerializeField]
	private float _experienceMultiplier;

	[SerializeField]
	private DBInt _dbCurrentExperience;

	[SerializeField]
	private DBInt _dbNextExpRequired;

	[SerializeField]
	private DBInt _dbPreviousExpRequired;

	private List<int> _levelsThreshold;

	private int _currentExperience;

	private int _currentLevel;

	private int _nextExpRequired;

	private int _previousRequiredExp;

	public void Initialize()
	{
	}

	public void UpdateExperience()
	{
	}

	public ExperienceModel LoadCurrentExperience()
	{
		return default(ExperienceModel);
	}

	private void SaveNextExpRequired()
	{
	}

	private void SavePreviousRequiredExp()
	{
	}

	private void SaveCurrentLevel()
	{
	}

	private void SaveCurrentExperience()
	{
	}

	private void AddExperienceData(ExperienceDataModel levelDataModel)
	{
	}
}
