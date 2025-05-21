using MS.Casual.IAP;
using MS.Store;
using UnityEngine;

namespace MS.Casual.Market
{
	public class MarketController
	{
		private IInAppReward<MarketItemData> _marketCoinsController;

		private IInAppReward<MarketItemData> _removeAdsController;

		private IInAppReward<MarketItemData> _marketRewardsController;

		private IInAppReward<MarketItemData> _marketCardsController;

		private SkipitOfferController _skipitOfferController;

		public MarketController(MonoBehaviour mono)
		{
		}

		private void OnPurchaseSuccess(TransactionRecord product, RestoreStatus restoreStatus, IAPRecordStatus status)
		{
		}

		private void RegisterEvents()
		{
		}

		private void UnRegisterEvents()
		{
		}

		private InAppRewardDataEvent GetRewardData(InAppIdDataEvent productId)
		{
			return default(InAppRewardDataEvent);
		}
	}
}
