public struct NextLockedItemDataModel
{
	public int NextItemID;

	public int CurrentUnlockScore;

	public int NextUnlockScore;

	public NextLockedItemDataModel(int nextItemID, int nextUnlockScore, int currentUnlockScore)
	{
		NextItemID = 0;
		CurrentUnlockScore = 0;
		NextUnlockScore = 0;
	}
}
