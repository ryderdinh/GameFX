using System.Collections.Generic;
using MSKit.UIView;

public class GameMenuView : BaseUIViewController<GameMenuViewRefs>
{
	private Dictionary<ActionButton, ActionButtonView> _actionButtons;

	private ScrollRectSnap _scroller;

	private BaseUIViewController[] _views;

	private int _currentIndex;

	private MarketView _marketView;

	private bool _isMarketNotificationAvailable;

	private MarketViewData _marketViewData;

	public override void Initialize()
	{
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

	private ActionButtonViewData OnGetHomeButtonRect()
	{
		return default(ActionButtonViewData);
	}

	private ActionButtonViewData OnGetFlowerUpgradesRect()
	{
		return default(ActionButtonViewData);
	}

	private ActionButton OnGetActiveMenu()
	{
		return default(ActionButton);
	}

	private void OnGoToShopPanel(MarketViewData marketViewData)
	{
	}

	private void OnGoToMainMenuPanelEvent()
	{
	}

	private void OnGoToFlowerMenuPanel()
	{
	}

	private void HideMarketNotificationOnClick(bool hideMarketNotification)
	{
	}

	public override void Show(object model = null)
	{
	}

	public override void Hide()
	{
	}

	private void LoadViews()
	{
	}

	private void SnapPanel(int index)
	{
	}

	private void UpdateActionBarState(int index)
	{
	}

	private void InitializeActionButtons()
	{
	}

	private void UpdateMarketButtonNotification()
	{
	}

	private void UpdateFlowerShopNotification()
	{
	}

	private void UpdateHomeNotification()
	{
	}

	private void GoToPanel(int index)
	{
	}

	private void GoToPanelFromNavBar(int index)
	{
	}

	private void Update()
	{
	}

	private void SetRectsInCanvas()
	{
	}

	private void SetActiveButton(int index)
	{
	}

	private void ResetButtonsExceptIndex(int index)
	{
	}

	private void ResetButton(int index)
	{
	}

	private void SetDividerState(bool state)
	{
	}
}
