using System;
using UnityEngine;

[Serializable]
public class SPPReward
{
	public SPPRewardType SPPRewardType;

	public RewardType Reward;

	public int RewardAmount;

	public bool IsSpecialReward;

	public int RewardSubIndex;

	private bool _isRewardClaimed;

	private Sprite _rewardIcon;

	public bool IsRewardClaimed => false;

	public Sprite RewardIcon => null;

	public void SetRewardClaimState(bool state)
	{
	}

	public void Initialize(Sprite rewardIcon, bool claimState)
	{
	}
}
