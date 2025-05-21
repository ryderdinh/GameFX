using System;

[Serializable]
public struct LevelData
{
	public int LevelNo;

	public int RequiredScore;

	public int AmyRewardCount;

	public int MetaUpgradeStars;

	public bool IsCheckPoint;

	public int ButterflySpawnCount;

	public int ButterflyRewardCount;

	public bool PrePopulateBoard;

	public int PrePopulationPresetId;
}
