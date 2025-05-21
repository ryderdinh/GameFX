using MS.Casual.Market;
using UnityEngine;

public class MarketRewardsController : IInAppReward<MarketItemData>
{
	private Camera _mainCamera;

	private readonly bool _isMainCameraNull;

	public void GiveReward(MarketItemData data, bool isRestore)
	{
	}

	private void GiveRewardWithAnimation(MarketItemData data)
	{
	}

	private void PlaySkipAdsRewardAnim(MarketItemData data, RewardAnimData animData)
	{
	}

	private void PlayCoinRewardAnim(MarketItemData data, RewardAnimData animData)
	{
	}

	private Vector3 GetSkipAdsRewardAnimStartPos(MarketItemData data, RewardAnimData animData)
	{
		return default(Vector3);
	}

	private Vector3 GetCoinRewardAnimStartPos(MarketItemData data, RewardAnimData animData)
	{
		return default(Vector3);
	}

	private RewardAnimData GetRewardAnimData(MarketItemData productData)
	{
		return default(RewardAnimData);
	}
}
