using System.Collections.Generic;

public class LevelDataController
{
	private readonly Dictionary<string, GameLevelDataList> _gameLevelData;

	private readonly List<LevelDataModel> _levelData;

	private void InitializeEvents()
	{
	}

	private void AddGameLevelData(GameLevelDataModel levelDataModel)
	{
	}

	private GameLevelDataModel GetGameLevelData(GameDataContainer gameData)
	{
		return default(GameLevelDataModel);
	}

	private void AddLevelData(LevelDataModel levelDataModel)
	{
	}

	private LevelDataModel GetLevelData(int levelId)
	{
		return default(LevelDataModel);
	}

	private int GetClampedLevelId(int levelId, int maxLevels)
	{
		return 0;
	}
}
