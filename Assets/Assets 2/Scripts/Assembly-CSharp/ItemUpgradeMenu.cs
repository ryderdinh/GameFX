using System.Collections.Generic;
using DG.Tweening;
using MSKit.UIView;
using UnityEngine;

public class ItemUpgradeMenu : BaseUIViewController<ItemUpgradeMenuViewRefs>, IItemUpgradeView
{
	private List<ItemUpgradeView> _itemUpgradeViews;

	private Dictionary<FlowerType, ItemUpgradeObject> _flowerUpgradesDictionary;

	private List<FlowerType> _flowersUpdated;

	private bool _showFlowerUnlockView;

	private bool _isOpenFromMenu;

	private Vector3 _defaultPositionsTopHUD;

	private Vector3 _defaultPositionsContainer;

	private bool _isClosing;

	[SerializeField]
	private ItemSystem _itemSystem;

	public override void Initialize()
	{
	}

	public override void Show(object model = null)
	{
	}

	private void CheckForForceSnapToBottom()
	{
	}

	private void ScrollView(bool top, float delay = 0f)
	{
	}

	private void ForceSnap(bool top)
	{
	}

	public override void Hide()
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

	private void OnBackButtonClicked()
	{
	}

	private void OpenMarket()
	{
	}

	private void UpdateMenu(bool forceUpdate)
	{
	}

	private void UpdateFlowerUpgradeButtonState()
	{
	}

	private void SetScrollBottomPosition()
	{
	}

	private void CloseButtonClicked()
	{
	}

	private void SetupView(bool animate = true)
	{
	}

	void IItemUpgradeView.ItemUpgraded(FlowerType flowerType, Vector3 position, float score)
	{
	}

	void IItemUpgradeView.ResetAllFlowerUpgradesButtonState()
	{
	}

	private void ResetAllFlowerUpgradesButtonState()
	{
	}

	private void AnimateView(bool state)
	{
	}

	private void MoveVertically(Transform transform, Vector3 pos, float delta, float duration, Ease ease, float delay = 0f)
	{
	}

	private void ForceMoveVertically(Transform transform, Vector3 pos, float delta)
	{
	}

	private void SetDefaultPositions()
	{
	}

	private void SetCloseButtonState(bool state)
	{
	}

	private void InfoButtonClicked()
	{
	}
}
