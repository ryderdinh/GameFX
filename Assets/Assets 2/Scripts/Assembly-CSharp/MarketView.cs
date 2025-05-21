using DG.Tweening;
using MSKit.UIView;
using UnityEngine;

public class MarketView : BaseUIViewController<MarketViewRefs>
{
	[SerializeField]
	private ContextualOffersObject _offersController;

	private Camera _uiCamera;

	private Sequence _boopCard;

	private Vector3 _defaultPositionsTopHUD;

	private Vector3 _defaultPositionsContainer;

	private MarketPacks _currentContext;

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

	private void StarterPackAvailabilityChanged(bool state)
	{
	}

	private void OnOfferCooldownStateChangedEvent(CooldownStateDataModel model)
	{
	}

	public override void Show(object model = null)
	{
	}

	public override void Hide()
	{
	}

	private void ShopShownFromMarket(MarketViewData marketData)
	{
	}

	private void PopulateMarket(MarketPacks marketPack)
	{
	}

	private void HideActiveOffers()
	{
	}

	private void SetSpecialPacksState(bool state)
	{
	}

	private void SetCardsPackState(bool state)
	{
	}

	private void SetSkipAdsPackState(bool state)
	{
	}

	private void SetOfferPackState(bool state, Offers offer)
	{
	}

	private void StarterPackPurchased()
	{
	}

	private void OnBackButtonClicked()
	{
	}

	private void CloseButtonPressed()
	{
	}

	private void SnapToCard(MarketPacks marketPack)
	{
	}

	private void ScrollView(bool top, float delay = 0f)
	{
	}

	private void ForceSnap(bool top)
	{
	}

	private void BoopCard(Transform card, float delay = 0.1f)
	{
	}

	private Vector3 GetInAppPosition(ProductName name)
	{
		return default(Vector3);
	}

	private void InitializeSpecialInApps(MarketPacks marketPack)
	{
	}

	private void InitializeInapps()
	{
	}

	private void HideOneTimeOffers()
	{
	}

	private void SetCloseButtonState(bool state)
	{
	}

	private void AnimateView(bool state)
	{
	}

	private void SetDefaultPositions()
	{
	}

	private void MoveVertically(Transform transform, Vector3 pos, float delta, float duration, Ease ease, float delay = 0f)
	{
	}

	private void ForceMoveVertically(Transform transform, Vector3 pos, float delta)
	{
	}

	private void SetScrollBottomPosition()
	{
	}
}
