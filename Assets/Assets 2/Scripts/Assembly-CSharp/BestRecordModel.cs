public struct BestRecordModel
{
	public bool IsWorldCompleted;

	public int HighestAchievedLevel;

	public int TotalLevels;

	public bool IsCurrentShop;

	public BestRecordModel(bool isWorldCompleted, int highestAchievedLevel, int totalLevels, bool isCurrentShop)
	{
		IsWorldCompleted = false;
		HighestAchievedLevel = 0;
		TotalLevels = 0;
		IsCurrentShop = false;
	}
}
