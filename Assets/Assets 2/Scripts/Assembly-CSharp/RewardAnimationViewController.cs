using UnityEngine;

public class RewardAnimationViewController : MonoBehaviour
{
	[SerializeField]
	private RewardAnimationView[] _rewardAnimationViews;

	[SerializeField]
	private Reward2DAnimationViewData[] _reward2DAnimationViewData;

	public void Initialize()
	{
	}

	public void ClaimDailyMission(RewardType missionReward, int rewardAmount, Vector3 startPosition)
	{
	}

	private int GetRewardAnimationViewIndex(RewardAnimationViewType rewardAnimationViewType)
	{
		return 0;
	}

	private Sprite Get2DRewardIcon(RewardType rewardType)
	{
		return null;
	}
}
