using System;
using UnityEngine;

[Serializable]
public class MatchesProgressMissionSPP
{
	public int Target;

	public SPPReward SPPReward;

	public SPPReward SPPPremiumReward;

	private int _id;

	public int ID => 0;

	public void Initialize(int id, Sprite rewardIcon, bool claimState, Sprite premiumRewardIcon, bool premiumClaimState)
	{
	}
}
