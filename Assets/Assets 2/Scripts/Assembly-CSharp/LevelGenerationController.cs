using System.Collections.Generic;

public class LevelGenerationController
{
	private readonly Queue<LevelDataModel> _gamesToPlay;

	private int _vipLevelInterval;

	private void InitializeEvents()
	{
	}

	private void OnSetVipGameInteval(int interval)
	{
	}

	private LevelDataModel GetGameToAssign(int rowId)
	{
		return default(LevelDataModel);
	}

	public bool IsVipGamePlayed()
	{
		return false;
	}

	public LevelDataModel GetCurrentGame()
	{
		return default(LevelDataModel);
	}

	public void RemoveLastPlayedGame()
	{
	}
}
