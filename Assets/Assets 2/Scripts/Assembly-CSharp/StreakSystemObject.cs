using System.Collections.Generic;
using DB;
using UnityEngine;

[CreateAssetMenu(fileName = "StreakSystem", menuName = "ScriptableObjects/StreakSystem")]
public class StreakSystemObject : ScriptableObject
{
	[SerializeField]
	private float _streakSpeedMultiplier;

	[SerializeField]
	private float _maxStreakSpeedMultiplier;

	[SerializeField]
	private int _movesToBreakStreak;

	[SerializeField]
	private DBInt _movesWithoutMatchCount;

	[SerializeField]
	private float _matchTime;

	[SerializeField]
	private int _maxCoinsAchieveableFromStreak;

	[SerializeField]
	private DBInt _dbMaxStreakCount;

	private Dictionary<FlowerType, Queue<int>> _streakDictionary;

	private int _streakCount;

	private int _timedMatchCount;

	private float _timePassedSinceMatch;

	private bool _initialCountSet;

	[SerializeField]
	private DBInt _dbStreakCount;

	private int _maxStreakCount;

	public int MaxCoinAchievableFromStreak => 0;

	public float StreakSpeedMultiplier => 0f;

	public int StreakCountForState()
	{
		return 0;
	}

	public int StreakCountForView(FlowerType flower)
	{
		return 0;
	}

	public int PeekStreakCount(FlowerType flower)
	{
		return 0;
	}

	public int PeekTimedMatchCount()
	{
		return 0;
	}

	public void Initialize()
	{
	}

	private void SetStreakCount()
	{
	}

	public void IncrementStreak(FlowerType flower)
	{
	}

	public void IncrementTimedMatchCount()
	{
	}

	public void ResetStreakCount(bool forceReset = false)
	{
	}
}
