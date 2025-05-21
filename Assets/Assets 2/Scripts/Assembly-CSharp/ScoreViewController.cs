using DB;
using UnityEngine;

public class ScoreViewController
{
	private Int _currentScore;

	private Int _currentLevelScore;

	private Int _highScore;

	public ScoreViewController(Int currentScore, Int currentLevelScore, Int highScore)
	{
	}

	public void UpdateView(Item mergedItem, int scoreToAdd, int streakCount, int score, int levelScore, Vector3 screenPoint, bool isComboMove, float animationStartDelay, bool isBoosterMerge, bool isTurboMode)
	{
	}

	private bool TryUpdateHighScoreText(int score, int highScore)
	{
		return false;
	}

	private void SetScoreText(float levelScore)
	{
	}

	private void SetHighScoreText()
	{
	}

	public void ResetView()
	{
	}
}
