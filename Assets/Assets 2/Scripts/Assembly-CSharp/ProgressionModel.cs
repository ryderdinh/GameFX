public struct ProgressionModel
{
	public int Matches;

	public float CurrentScore;

	public CurrentLevelData CurrentLevelData;

	public int HighestLevelReached;

	public ProgressionModel(float currentScore, CurrentLevelData currentLevelData, int matches, int highestLevelReached)
	{
		Matches = 0;
		CurrentScore = 0f;
		CurrentLevelData = default(CurrentLevelData);
		HighestLevelReached = 0;
	}
}
