public interface IMatchesProgressMissionSPP
{
	bool ClaimReward(int id, RewardType reward, int rewardAmount, int rewardSubIndex, SPPRewardType sppRewardType);

	int UnclaimedMissionIndex();
}
