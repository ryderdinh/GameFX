public struct LevelDataModel : ILevelData
{
	public int LevelId { get; }

	public GameType GameType { get; }

	public bool IsVIP { get; }

	public LevelDataModel(int levelId, GameType game, bool isVip)
	{
		LevelId = 0;
		GameType = default(GameType);
		IsVIP = false;
	}
}
