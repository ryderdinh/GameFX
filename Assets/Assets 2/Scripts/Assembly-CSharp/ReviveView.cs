using MSKit.UIView;
using UnityEngine;

public class ReviveView : BaseUIViewController<ReviveViewRefs>, IPowerUpView
{
	private bool _showRevive;

	private bool _isReviveWarningShown;

	private bool _isGiftReviveWarningShown;

	private IReviveView _reviveView;

	private Vector3 _revivesGroupInitialPosition;

	public override void Initialize()
	{
	}

	public bool Show(IReviveView reviveView)
	{
		return false;
	}

	public override void InitializeButtons()
	{
	}

	public override void InitializeTexts()
	{
	}

	public override void RegisterEvents()
	{
	}

	public override void UnregisterEvents()
	{
	}

	private void SetWaterParticlesState(bool state)
	{
	}

	private void ResetView()
	{
	}

	private void ShowReviveScreen()
	{
	}

	private void ResetReviveView()
	{
	}

	private void SwitchToWarningView()
	{
	}

	private void SwitchToGiftWarningView()
	{
	}

	private void HideReviveScreen()
	{
	}

	private void HideLiveOpsOfferView()
	{
	}

	private void ReviveBuyButtonClicked()
	{
	}

	private void AdReviveClicked(bool adWatched)
	{
	}

	private void Revive()
	{
	}

	private void HideView()
	{
	}

	private void UpdateReviveViewState()
	{
	}

	private void HideAllReviveButtons()
	{
	}

	public void OnPointerDown()
	{
	}

	public void OnPointerUp()
	{
	}

	private void PointerDownAndHold()
	{
	}

	private void PointerUp()
	{
	}

	private void FadeCanvas(float value, float time)
	{
	}

	void IPowerUpView.PowerUpUsed()
	{
	}
}
