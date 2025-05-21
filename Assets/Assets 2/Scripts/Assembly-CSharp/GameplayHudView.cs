using DG.Tweening;
using MSKit.UIView;
using UnityEngine;

public class GameplayHudView : BaseUIViewController<GameplayHudViewRefs>, IGameplayHudView, IPowerUpView
{
	private Vector3 _defaultPositionsTopHUD;

	private Vector3 _defaultPositionPauseButton;

	private Vector3 _defaultCardsChestPosition;

	private Vector3 _defaultPositionRemoveAds;

	private Vector3 _defaultPositionMissionCenterButton;

	private bool _first;

	private bool _currentState;

	private ItemUpgradeSystem _itemUpgradeSystem;

	public override void Initialize()
	{
	}

	public override void RegisterEvents()
	{
	}

	public override void UnregisterEvents()
	{
	}

	private ActionButton OnGetActiveMenu()
	{
		return default(ActionButton);
	}

	public override void Show(object model = null)
	{
	}

	private void ShowAmy()
	{
	}

	private void UpdateHud(bool isTurboMode = false)
	{
	}

	public override void InitializeTexts()
	{
	}

	public override void InitializeButtons()
	{
	}

	private void FlowerMenuClicked()
	{
	}

	private void PauseButtonClicked()
	{
	}

	public override void Hide()
	{
	}

	private void ShowTutorial(bool isTutorialActive)
	{
	}

	private void ShowGiftTutorial(bool show)
	{
	}

	private void SetGameplayHudState(GameplayHudData data)
	{
	}

	private void AnimateGameplayHud(GameplayHudData data)
	{
	}

	private void AnimateInAmy(float intialDelay, float scaleInDelay)
	{
	}

	private void SetDefaultPositions()
	{
	}

	private void ClearView()
	{
	}

	private void ResetConfettiParticles()
	{
	}

	private void ShopComplete()
	{
	}

	private void PlayConfettiParticles(bool playSound = true, bool hideBar = true)
	{
	}

	private void SetEarningsTextState(bool state)
	{
	}

	private void ShowFlowerUpgradeMenuTutorial()
	{
	}

	private void IsFlowerUpgradeMenuTutorialAvailable()
	{
	}

	private void SetChestState()
	{
	}

	private void MoveVertically(Transform transform, Vector3 pos, float delta, float duration, Ease ease, float delay = 0f)
	{
	}

	private void ForceMoveVertically(Transform transform, Vector3 pos, float delta)
	{
	}

	private void MoveHorizontally(Transform transform, Vector3 pos, float delta, float duration, Ease ease)
	{
	}

	private void ForceMoveHorizontally(Transform transform, Vector3 pos, float delta)
	{
	}

	private void SetBlockerState(bool state)
	{
	}

	void IGameplayHudView.ShowLevelCompleteBanner(int level)
	{
	}

	void IGameplayHudView.ShowCheckPointBanner()
	{
	}

	void IPowerUpView.PowerUpUsed()
	{
	}

	void IGameplayHudView.UpdateHud(int index)
	{
	}
}
