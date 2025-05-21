using DG.Tweening;
using UnityEngine;

public class MetaMenuView : BaseUISubViewController<MetaMenuViewRefs>, IMetaMenuView
{
	private IMainMenu _mainMenuHandler;

	private int _currentIndex;

	private int _upgradeIndex;

	private bool _metaUpgradeTransitionPlaying;

	private Vector3 _backBtnDefaultPosition;

	public override void Initialize()
	{
	}

	public override void Show(object model = null)
	{
	}

	public override void InitializeButtons()
	{
	}

	private void Update()
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

	private void LeftScrollButtonClicked()
	{
	}

	private void RightScrollButtonClicked()
	{
	}

	private void GoToPanel(int index, float delay = 0f, bool isInitialization = false)
	{
	}

	private void BackButtonClicked()
	{
	}

	private void SetDefaultPositions()
	{
	}

	private void SetMenuObjectsState(bool showBackBtn = false, bool showTutorial = false)
	{
	}

	private void ClearView()
	{
	}

	private void PlayWorldCompletedTransition()
	{
	}

	private void MoveVertically(Transform transform, Vector3 pos, float delta, float duration, Ease ease, float delay = 0f)
	{
	}

	private void ForceMoveVertically(Transform transform, Vector3 pos, float delta)
	{
	}

	private void SetRightButtonState(bool state)
	{
	}

	private void SetLeftButtonState(bool state)
	{
	}

	private void SetCompletedTextState(bool state)
	{
	}

	private void SetGodRaysState(int index)
	{
	}

	void IMetaMenuView.SetPlayButtonState(bool state, bool upgradeButtonState)
	{
	}

	void IMetaMenuView.WorldComplete()
	{
	}
}
