public interface ISPPRewardView
{
	bool ClaimReward(RewardType reward, int rewardAmount, int rewardSubIndex, SPPRewardType sppRewardType);

	int UnclaimedMissionIndex();
}
