using DB;

public class ScoreStateController
{
	private DBInt _dbHighScore;

	private DBInt _dbLastHighScore;

	private DBInt _dbCurrentScore;

	private DBInt _dbCurrentLevelScore;

	public ScoreStateController(DBInt dbHighScore, DBInt dbCurrentScore, DBInt dbCurrentLevelScore, DBInt dbLastHighScore)
	{
	}

	public void UpdateState(int score, int levelScore)
	{
	}

	public void ResetState()
	{
	}

	private bool TryUpdateHighScoreState(int score, int highScore)
	{
		return false;
	}

	private void SaveHighScore(int highScore)
	{
	}

	private void SaveLastHighScore(int lastHighScore)
	{
	}

	private void SaveCurrentScore(int score)
	{
	}

	private void SaveCurrentLevelScore(int levelScore)
	{
	}
}
