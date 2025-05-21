using UnityEngine;

public class LevelConfig : ScriptableObject
{
	[Header("Level Data")]
	public float LevelWrappingPercentage;

	[Header("Games")]
	public GameType[] AvailableGames;
}
