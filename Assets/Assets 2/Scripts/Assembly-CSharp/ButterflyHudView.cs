using DG.Tweening;
using MSKit.UIView;
using UnityEngine;

public class ButterflyHudView : BaseUIViewController<ButterflyHudViewRefs>
{
	private Sequence _collectableSequence;

	private ButterflyConfigs _configs;

	private ScoreSystem _scoreSystem;

	private ButterflyProgressData _progressData;

	private bool _butterflyUnlocked;

	private int _previousScore;

	public override void Initialize()
	{
	}

	public override void Show(object model = null)
	{
	}

	public override void RegisterEvents()
	{
	}

	public override void UnregisterEvents()
	{
	}

	public override void InitializeTexts()
	{
	}

	private void UpdateButterflyCount(float currentScore, bool matchMade = false, bool isInit = false)
	{
	}

	private void UpdateProgressText(float x)
	{
	}

	public void UpdateButterflyHudWithTrailAnimation(float currentScore, Vector3 startPos)
	{
	}

	public override void InitializeButtons()
	{
	}

	private void OnButterflySpawnedEvent()
	{
	}

	private void OnButterflyExitEvent()
	{
	}

	private void OnLevelUpEvent(LevelUpData levelUpData)
	{
	}

	private void InitializeCollectables()
	{
	}

	private void ButterflyActiveState(bool state)
	{
	}

	private void UpdateLockedState(bool state, string text)
	{
	}
}
