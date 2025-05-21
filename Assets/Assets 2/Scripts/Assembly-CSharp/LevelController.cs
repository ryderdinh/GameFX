public class LevelController
{
	private readonly LevelProgressController _levelProgressController;

	private readonly LevelDataController _levelDataController;

	private readonly LevelGenerationController _levelGenerationController;

	public void RemoveLastGame()
	{
	}

	public LevelDataModel GetCurrentGame()
	{
		return default(LevelDataModel);
	}

	public void SkipGame()
	{
	}
}
