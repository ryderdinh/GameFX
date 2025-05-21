using UnityEngine;

namespace Analytics
{
	[CreateAssetMenu(fileName = "AnalyticsAdjustTokens", menuName = "Analytics/AnalyticsAdjustTokens")]
	public class AnalyticsAdjustTokens : ScriptableObject
	{
		[SerializeField]
		private string _adjustAppTokenIOS;

		[SerializeField]
		private string _adjustAppTokenAndroid;

		[SerializeField]
		[Space]
		[Header("Inters")]
		[Space]
		private string[] _intersWatchedIosEventId;

		[SerializeField]
		private string[] _intersWatchedAndroidEventId;

		[Space]
		[SerializeField]
		private string[] _intersWatchedExtendedIosEventId;

		[SerializeField]
		private string[] _intersWatchedExtendedAndroidEventId;

		[Space]
		[Header("Rvs")]
		[Space]
		[SerializeField]
		private string[] _rvsWatchedIosEventId;

		[SerializeField]
		private string[] _rvsWatchedAndroidEventId;

		[Space]
		[SerializeField]
		private string[] _rvsWatchedExtendedIosEventId;

		[SerializeField]
		private string[] _rvsWatchedExtendedAndroidEventId;

		[SerializeField]
		[Space]
		private string[] _rvsWatchedDoubleExtendedIosEventId;

		[SerializeField]
		private string[] _rvsWatchedDoubleExtendedAndroidEventId;

		[Space]
		[Header("Level Complete")]
		[SerializeField]
		[Space]
		private string[] _levelCompleteIosEventId;

		[SerializeField]
		private string[] _levelCompleteAndroidEventId;

		[SerializeField]
		[Space]
		private string[] _levelCompleteExtendedIosEventId;

		[SerializeField]
		private string[] _levelCompleteExtendedAndroidEventId;

		[SerializeField]
		[Space]
		private string[] _levelCompleteDoubleExtendedIosEventId;

		[SerializeField]
		private string[] _levelCompleteDoubleExtendedAndroidEventId;

		[Space]
		[SerializeField]
		private string[] _levelCompleteTripleExtendedIosEventId;

		[SerializeField]
		private string[] _levelCompleteTripleExtendedAndroidEventId;

		[Space]
		[Header("IAPs")]
		[Space]
		[Header("All Skus")]
		[Space]
		[SerializeField]
		private string _iapAllSkusIosEventId;

		[SerializeField]
		private string _iapAllSkusAndroidEventId;

		[SerializeField]
		[Header("Verification")]
		[Space]
		[Space]
		private string _iapPurchaseIOSEventId;

		[SerializeField]
		private string _iapPurchaseAndroidEventId;

		[Space]
		[SerializeField]
		private string _iapPurchaseFailedIOSEventId;

		[SerializeField]
		private string _iapPurchaseFailedAndroidEventId;

		[SerializeField]
		[Space]
		private string _iapPurchaseInvalidIOSEventId;

		[SerializeField]
		private string _iapPurchaseInvalidAndroidEventId;

		[SerializeField]
		[Space]
		private string _iapPurchaseUnknownIOSEventId;

		[SerializeField]
		private string _iapPurchaseUnknownAndroidEventId;

		[Space]
		[SerializeField]
		private string _iapPurchaseValidIOSEventId;

		[SerializeField]
		private string _iapPurchaseValidAndroidEventId;

		[SerializeField]
		[Space]
		[Header("Coins")]
		[Space]
		private string _iapCoins1000IosEventId;

		[SerializeField]
		private string _iapCoins1000AndroidEventId;

		[Space]
		[SerializeField]
		private string _iapCoins5000IosEventId;

		[SerializeField]
		private string _iapCoins5000AndroidEventId;

		[Space]
		[SerializeField]
		private string _iapCoins10000IosEventId;

		[SerializeField]
		private string _iapCoins10000AndroidEventId;

		[Space]
		[SerializeField]
		private string _iapCoins25000IosEventId;

		[SerializeField]
		private string _iapCoins25000AndroidEventId;

		[Space]
		[SerializeField]
		private string _iapCoins50000IosEventId;

		[SerializeField]
		private string _iapCoins50000AndroidEventId;

		[Space]
		[SerializeField]
		private string _iapCoins100000IosEventId;

		[SerializeField]
		private string _iapCoins100000AndroidEventId;

		[Header("Skip Ads")]
		[Space]
		[SerializeField]
		[Space]
		private string _iapSkipAds10IosEventId;

		[SerializeField]
		private string _iapSkipAds10AndroidEventId;

		[Space]
		[SerializeField]
		private string _iapSkipAds30IosEventId;

		[SerializeField]
		private string _iapSkipAds30AndroidEventId;

		[Space]
		[SerializeField]
		private string _iapSkipAds100IosEventId;

		[SerializeField]
		private string _iapSkipAds100AndroidEventId;

		[Header("Card Packs")]
		[Space]
		[SerializeField]
		[Space]
		private string _iapCardsPack60IosEventId;

		[SerializeField]
		private string _iapCardsPack60AndroidEventId;

		[Space]
		[SerializeField]
		private string _iapCardsPack300IosEventId;

		[SerializeField]
		private string _iapCardsPack300AndroidEventId;

		[Space]
		[SerializeField]
		private string _iapCardsPack1000IosEventId;

		[SerializeField]
		private string _iapCardsPack1000AndroidEventId;

		[Space]
		[Header("Coin Offers")]
		[Space]
		[SerializeField]
		private string _iapStarterPackIosEventId;

		[SerializeField]
		private string _iapStarterPackAndroidEventId;

		[Space]
		[SerializeField]
		private string _iapSpecialOfferIosEventId;

		[SerializeField]
		private string _iapSpecialOfferAndroidEventId;

		[Space]
		[SerializeField]
		private string _iapMasterOfferIosEventId;

		[SerializeField]
		private string _iapMasterOfferAndroidEventId;

		[Space]
		[SerializeField]
		private string _iapSuperOfferIosEventId;

		[SerializeField]
		private string _iapSuperOfferAndroidEventId;

		[Space]
		[SerializeField]
		private string _iapMegaOfferIosEventId;

		[SerializeField]
		private string _iapMegaOfferAndroidEventId;

		[Space]
		[SerializeField]
		private string _iapGiantOfferIosEventId;

		[SerializeField]
		private string _iapGiantOfferAndroidEventId;

		[Space]
		[SerializeField]
		private string _iapLegendaryOfferIosEventId;

		[SerializeField]
		private string _iapLegendaryOfferAndroidEventId;

		[SerializeField]
		[Space]
		private string _iapSkipAdsOfferIosEventId;

		[SerializeField]
		private string _iapSkipAdsOfferAndroidEventId;

		[SerializeField]
		[Space]
		[Header("SkipAds Offers")]
		[Space]
		private string _iapSkipAdsSpecialOfferIosEventId;

		[SerializeField]
		private string _iapSkipAdsSpecialOfferAndroidEventId;

		[SerializeField]
		[Space]
		private string _iapSkipAdsMasterOfferIosEventId;

		[SerializeField]
		private string _iapSkipAdsMasterOfferAndroidEventId;

		[Space]
		[SerializeField]
		private string _iapSkipAdsSuperOfferIosEventId;

		[SerializeField]
		private string _iapSkipAdsSuperOfferAndroidEventId;

		[Space]
		[SerializeField]
		private string _iapSkipAdsMegaOfferIosEventId;

		[SerializeField]
		private string _iapSkipAdsMegaOfferAndroidEventId;

		[Space]
		[SerializeField]
		private string _iapSkipAdsGiantOfferIosEventId;

		[SerializeField]
		private string _iapSkipAdsGiantOfferAndroidEventId;

		[Space]
		[SerializeField]
		private string _iapSkipAdsLegendaryOfferIosEventId;

		[SerializeField]
		private string _iapSkipAdsLegendaryOfferAndroidEventId;

		[Space]
		[Header("Cards Offers")]
		[Space]
		[SerializeField]
		private string _iapCardsSpecialOfferIosEventId;

		[SerializeField]
		private string _iapCardsSpecialOfferAndroidEventId;

		[Space]
		[SerializeField]
		private string _iapCardsMasterOfferIosEventId;

		[SerializeField]
		private string _iapCardsMasterOfferAndroidEventId;

		[SerializeField]
		[Space]
		private string _iapCardsSuperOfferIosEventId;

		[SerializeField]
		private string _iapCardsSuperOfferAndroidEventId;

		[SerializeField]
		[Space]
		private string _iapCardsMegaOfferIosEventId;

		[SerializeField]
		private string _iapCardsMegaOfferAndroidEventId;

		[SerializeField]
		[Space]
		private string _iapCardsGiantOfferIosEventId;

		[SerializeField]
		private string _iapCardsGiantOfferAndroidEventId;

		[Space]
		[SerializeField]
		private string _iapCardsLegendaryOfferIosEventId;

		[SerializeField]
		private string _iapCardsLegendaryOfferAndroidEventId;

		[SerializeField]
		[Space]
		[Header("Singles")]
		[Space]
		private string _iapRemoveAdsIosEventId;

		[SerializeField]
		private string _iapRemoveAdsAndroidEventId;

		[Space]
		[SerializeField]
		private string _iapRemoveAdsDiscounted1IosEventId;

		[SerializeField]
		private string _iapRemoveAdsDiscounted1AndroidEventId;

		[SerializeField]
		[Space]
		private string _iapRemoveAdsDiscounted2IosEventId;

		[SerializeField]
		private string _iapRemoveAdsDiscounted2AndroidEventId;

		[Space]
		[Header("LiveOps Offers")]
		[Space]
		[SerializeField]
		private string _iapLiveOpsOffer1IosEventId;

		[SerializeField]
		private string _iapLiveOpsOffer1AndroidEventId;

		[Space]
		[SerializeField]
		private string _iapLiveOpsOffer2IosEventId;

		[SerializeField]
		private string _iapLiveOpsOffer2AndroidEventId;

		[SerializeField]
		[Space]
		private string _iapLiveOpsOffer3IosEventId;

		[SerializeField]
		private string _iapLiveOpsOffer3AndroidEventId;

		[Space]
		[Space]
		[SerializeField]
		[Header("LiveOps Offers")]
		private string _iapBloomPassIosEventId;

		[SerializeField]
		private string _iapBloomPassAndroidEventId;

		public string AdjustAppToken => null;

		public string IAPAllSkusEventId => null;

		public string IAPPurchaseEventId => null;

		public string IAPPurchaseFailedEventId => null;

		public string IAPPurchaseInvalidEventId => null;

		public string IAPPurchaseUnknownEventId => null;

		public string IAPPurchaseValidEventId => null;

		public string IAPCoins1000EventId => null;

		public string IAPCoins5000EventId => null;

		public string IAPCoins10000EventId => null;

		public string IAPCoins25000EventId => null;

		public string IAPCoins50000EventId => null;

		public string IAPCoins100000EventId => null;

		public string IAPSkipAds10EventId => null;

		public string IAPSkipAds30EventId => null;

		public string IAPSkipAds100EventId => null;

		public string IAPCardsPack60EventId => null;

		public string IAPCardsPack300EventId => null;

		public string IAPCardsPack1000EventId => null;

		public string IAPStarterPackEventId => null;

		public string IAPSpecialOfferEventId => null;

		public string IAPMasterOfferEventId => null;

		public string IAPSuperOfferEventId => null;

		public string IAPMegaOfferEventId => null;

		public string IAPGiantOfferEventId => null;

		public string IAPLegendaryOfferEventId => null;

		public string IAPSkipAdsOfferEventId => null;

		public string IAPSkipAdsSpecialOfferEventId => null;

		public string IAPSkipAdsMasterOfferEventId => null;

		public string IAPSkipAdsSuperOfferEventId => null;

		public string IAPSkipAdsMegaOfferEventId => null;

		public string IAPSkipAdsGiantOfferEventId => null;

		public string IAPSkipAdsLegendaryOfferEventId => null;

		public string IAPCardsSpecialOfferEventId => null;

		public string IAPCardsMasterOfferEventId => null;

		public string IAPCardsSuperOfferEventId => null;

		public string IAPCardsMegaOfferEventId => null;

		public string IAPCardsGiantOfferEventId => null;

		public string IAPCardsLegendaryOfferEventId => null;

		public string IAPRemoveAdsEventId => null;

		public string IAPRemoveAdsDiscounted1EventId => null;

		public string IAPRemoveAdsDiscounted2EventId => null;

		public string IAPLiveOpsOffer1EventId => null;

		public string IAPLiveOpsOffer2EventId => null;

		public string IAPLiveOpsOffer3EventId => null;

		public string IAPBloomPassEventId => null;

		public string IntersWatchedEventId(int index)
		{
			return null;
		}

		public string IntersWatchedExtendedEventId(int index)
		{
			return null;
		}

		public string RvWatchedEventId(int index)
		{
			return null;
		}

		public string RvWatchedExtendedEventId(int index)
		{
			return null;
		}

		public string RvWatchedDoubleExtendedEventId(int index)
		{
			return null;
		}

		public string LevelCompleteEventId(int index)
		{
			return null;
		}

		public string LevelCompleteExtendedEventId(int index)
		{
			return null;
		}

		public string LevelCompleteDoubleExtendedEventId(int index)
		{
			return null;
		}

		public string LevelCompleteTripleExtendedEventId(int index)
		{
			return null;
		}
	}
}
