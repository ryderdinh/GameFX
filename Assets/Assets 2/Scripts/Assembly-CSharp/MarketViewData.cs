public struct MarketViewData
{
	public MarketPacks MarketPacks;

	public bool IsOpenFromMenu;

	public bool ShowBannerOnClose;

	public IAPOfferContext IAPOfferContext;

	public MarketViewData(MarketPacks marketPacks, bool isOpenFromMenu, IAPOfferContext iAPOfferContext, bool showBannerOnClose = true)
	{
		MarketPacks = default(MarketPacks);
		IsOpenFromMenu = false;
		ShowBannerOnClose = false;
		IAPOfferContext = default(IAPOfferContext);
	}
}
