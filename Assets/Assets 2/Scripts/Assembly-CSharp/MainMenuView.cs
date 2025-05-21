using DG.Tweening;
using MSKit.UIView;
using UnityEngine;

public class MainMenuView : BaseUIViewController<MainMenuViewRefs>, IMainMenu
{
	private Camera _uiCamera;

	private Vector3[] _defaultUpPositions;

	private Vector3[] _defaultDownPositions;

	private Vector3[] _defaultRightPositions;

	private Vector3[] _defaultLeftPositions;

	private MainMenuType _mainMenuType;

	public override void Initialize()
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

	public override void Show(object model = null)
	{
	}

	private void ShowHelpShiftButton()
	{
	}

	private void OnHelpShiftViewOpened()
	{
	}

	private void UpdateHelpShiftObjectState(bool state)
	{
	}

	private void PlayClicked()
	{
	}

	private void SettingClicked()
	{
	}

	public override void InitializeButtons()
	{
	}

	private void SPPButtonClicked()
	{
	}

	private void SetDefaultPositions()
	{
	}

	private void SetMenuObjectsState(bool state)
	{
	}

	private void ClearView()
	{
	}

	private void MoveVertically(Transform transform, Vector3 pos, float delta, float duration, Ease ease, float delay = 0f)
	{
	}

	private void ForceMoveVertically(Transform transform, Vector3 pos, float delta)
	{
	}

	private void MoveHorizontally(Transform transform, Vector3 pos, float delta, float duration, Ease ease, float delay = 0f)
	{
	}

	private void ForceMoveHorizontally(Transform transform, Vector3 pos, float delta)
	{
	}

	public override void Hide()
	{
	}

	private Vector3 GetCoinsPosition()
	{
		return default(Vector3);
	}

	void IMainMenu.SetMainMenuState(bool state)
	{
	}

	void IMainMenu.PlayButtonClicked()
	{
	}

	void IMainMenu.UpdateMetaData(string name, BestRecordModel data)
	{
	}

	private void FlowerMenuClicked()
	{
	}

	private void UpdateFlowerShopNotification()
	{
	}

	private void SwitchButtonsAnimatorState(bool state)
	{
	}

	private void OnEventStart()
	{
	}

	private void InitializeLiveOps()
	{
	}

	private void ShowLiveOps()
	{
	}

	private void ShowEventIntro()
	{
	}

	private void LiveOpsIconsAnimationOnIntro(HudEventIntroAnimationData hudEventIntroAnimationData)
	{
	}
}
