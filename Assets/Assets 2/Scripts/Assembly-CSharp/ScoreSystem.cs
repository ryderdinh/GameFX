using DB;
using UnityEngine;

[CreateAssetMenu(fileName = "ScoreSystem", menuName = "ScriptableObjects/ScoreSystem")]
public class ScoreSystem : ScriptableObject
{
	[SerializeField]
	private Int _highScore;

	[SerializeField]
	private Int _currentScore;

	[SerializeField]
	private Int _currentLevelScore;

	[SerializeField]
	private Int _finalScore;

	[SerializeField]
	private Int _lastScore;

	[SerializeField]
	private DBInt _dbHighScore;

	[SerializeField]
	private DBInt _dbLastHighScore;

	[SerializeField]
	private DBInt _dbCurrentScore;

	[SerializeField]
	private DBInt _dbCurrentLevelScore;

	[SerializeField]
	private int[] _scoresToActiveHardMode;

	[SerializeField]
	private MetaWorldConfig _metaWorldConfig;

	[SerializeField]
	private TurboModeSystem _turboModeSystem;

	private ScoreStateController ScoreStateController;

	private ScoreViewController ScoreViewController;

	public int CurrentScoreInt => 0;

	public int CurrentScore => 0;

	public int CurrentLevelScore => 0;

	public int HighScore => 0;

	public int GetFinalScore()
	{
		return 0;
	}

	public int GetCurrentScore()
	{
		return 0;
	}

	public int GetCurrentLevelScore()
	{
		return 0;
	}

	public int GetHighScore()
	{
		return 0;
	}

	public void Initialize()
	{
	}

	public bool IsHardModeActive()
	{
		return false;
	}

	public void ResetScoreProgress(bool resetView)
	{
	}

	public void UpdateScoreState(Item mergedItem, int streakCount, float scorePercentage, bool isBoosterMerge, bool isTurboMode)
	{
	}

	public void ForceSetCurrentLevelOnLevelInitialize(int lastRequiredScore)
	{
	}

	public void ForceSetScoreOnLevelInitializeComplete(int lastRequiredScore)
	{
	}

	public void SetCurrentLevelScoreOnLevelComplete(int lastRequiredScore)
	{
	}

	public void ForceUpdatedScoreOnLevelReset(int score)
	{
	}

	public void UpdateScoreView(Item mergedItem, int streakCount, Vector3 screenPoint, bool isComboMove, float scorePercentage, float animationStartDelay, bool isBoosterMerge, bool isTurboMode)
	{
	}

	private void UpdateFinalScore()
	{
	}
}
