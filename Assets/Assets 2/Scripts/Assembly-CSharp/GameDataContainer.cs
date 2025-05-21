public struct GameDataContainer
{
	public GameType Game;

	public int LevelId;

	public GameDataContainer(GameType game, int levelId)
	{
		Game = default(GameType);
		LevelId = 0;
	}
}
