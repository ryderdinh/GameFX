using System;
using System.Collections.Generic;
using DG.Tweening;
using MSKit.ResourcePool;
using MSKit.UIView;
using UnityEngine;

public class ItemProgressView : BaseUIViewController<ItemProgressViewRefs>
{
	[SerializeField]
	private MatchesSystem _matchesSystem;

	private float _currentScore;

	private float _requiredScore;

	private float _lastUnlockedItemScore;

	private float _cumulativeRequiredScore;

	private bool _showingProgress;

	private Sequence _collectableSequence;

	private int _activatedNotchCount;

	private Vector3 _defaultGiftScale;

	private Vector3 _progressBarDefaultPosition;

	private IGameplayHudView _gameplayHudViewHandler;

	private Sequence _giftHighlightSequence;

	private Dictionary<int, Pool<TrailCollectable>> _trailsDictionary;

	private LevelSystem _levelSystem;

	public override void Initialize()
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

	public override void InitializeButtons()
	{
	}

	public override void Show(object model = null)
	{
	}

	private void UpdateProgress(bool updateCurrentScore = false)
	{
	}

	private void CannotShowProgress()
	{
	}

	private void UpdateItemProgress(float score, Action action = null, bool initialize = false)
	{
	}

	private void UpdateLevelData(bool updateCurrentScore = false)
	{
	}

	private void UpdateProgressText(float x)
	{
	}

	private void AnimateGiftBox()
	{
	}

	private void OnLevelComplete(LevelUpData levelUpData)
	{
	}

	private void SetGiftBoxIconState(bool state)
	{
	}

	private void OnLevelReset()
	{
	}

	private void PlayCollectablesAnimation(CollectablesData data)
	{
	}

	private void UpdateScoreWithTrailAnimation(CollectablesData data)
	{
	}

	private void PlayCollectableAnimation(RectTransform collectable, float duration, Vector3[] path, Action action)
	{
	}

	private Vector2 GetScreenPosition(Vector3 pos)
	{
		return default(Vector2);
	}

	private void AmyClicked()
	{
	}

	private void UpdateProgressBar(bool levelCompleted = false)
	{
	}

	private void InitializeTrails()
	{
	}

	private void MoveHorizontally(Transform transform, Vector3 pos, float delta, float duration, Ease ease)
	{
	}

	private void ForceMoveHorizontally(Transform transform, Vector3 pos, float delta)
	{
	}
}
