public struct PieceSortLevelDataModel : ILevelData
{
	public int LevelId { get; }

	public GameType GameType { get; }

	public PieceSortLevelDataModel(int levelId, GameType gameType)
	{
		LevelId = 0;
		GameType = default(GameType);
	}
}
