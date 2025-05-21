using System;

namespace MS.Casual.Market
{
	public struct SpecialOfferViewData
	{
		public ISpecialOffer SpecialOffer;

		public bool IsInGame;

		public ISkipAdsPurchaseView SkipAdsPurchaseView;

		public Action Callback;

		public SpecialOfferViewData(ISpecialOffer specialOffer, bool isInGame)
		{
			SpecialOffer = null;
			IsInGame = false;
			SkipAdsPurchaseView = null;
			Callback = null;
		}

		public SpecialOfferViewData(ISpecialOffer specialOffer, ISkipAdsPurchaseView skipAdsPurchaseView)
		{
			SpecialOffer = null;
			IsInGame = false;
			SkipAdsPurchaseView = null;
			Callback = null;
		}
	}
}
