using DG.Tweening;
using MSKit.UIView;
using UnityEngine;

public abstract class BaseBoosterView : BaseUIViewController<BaseBoosterViewRefs>
{
	private float _closeButtonScale;

	private Vector3 _iconDefaultPosition;

	private Vector3 _iconDefaultScale;

	protected Boosters _configs;

	private GameObject _spawnedIcon;

	private BoosterViewInfo _boosterViewInfo;

	private Vector3 _boosterNameRectPosition;

	private Vector3 _boosterDescriptionRectPosition;

	private Vector2 _boosterDescriptionRectSizeDelta;

	public override void InitializeButtons()
	{
	}

	public override void InitializeTexts()
	{
	}

	public override void Initialize()
	{
	}

	public override void Hide()
	{
	}

	public override void Show(object model = null)
	{
	}

	private void UpdateBoosterDescriptionRectDelta()
	{
	}

	private void ResetRects()
	{
	}

	private void ResetTweens()
	{
	}

	private void SetBoosterNameSprite()
	{
	}

	private void AnimateInBoosterName(TweenCallback callBack)
	{
	}

	private void SetIcon(int itemId)
	{
	}

	private void BoosterIconAnimation(TweenCallback callBack)
	{
	}

	public override void RegisterEvents()
	{
	}

	public override void UnregisterEvents()
	{
	}

	protected abstract void OnCloseClick();

	private void HideText()
	{
	}

	private void ShowText()
	{
	}

	private void SetCloseButtonState(bool state)
	{
	}

	private void OnHideBoosterInfoHeader()
	{
	}
}
