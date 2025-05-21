using System;
using UnityEngine;

[Serializable]
public struct MissionDifficultyData
{
	[SerializeField]
	private MissionDifficulty _missionDifficulty;

	[SerializeField]
	private int _amount;

	[SerializeField]
	private int _probability;

	public MissionDifficulty MissionDifficulty => default(MissionDifficulty);

	public int TotalAmount => 0;

	public int Probability => 0;
}
