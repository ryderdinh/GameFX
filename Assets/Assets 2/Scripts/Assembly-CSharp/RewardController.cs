using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "RewardController", menuName = "ScriptableObjects/RewardController")]
public class RewardController : ScriptableObject
{
	[SerializeField]
	private MissionRewardObject[] _missionRewardObjects;

	[SerializeField]
	private CardsItemData[] _cardsItemsData;

	[SerializeField]
	private FlowerCardSource _flowerCardSource;

	private Camera _mainCamera;

	private bool _isMainCameraNull;

	public void Initialize()
	{
	}

	public Sprite GetRewardIcon(RewardType missionReward, int index)
	{
		return null;
	}

	public void PlayRewardAnimation(Dictionary<RewardType, int> rewards)
	{
	}

	private void PlayCoinRewardAnim(int count, Vector3 startPos)
	{
	}

	private void PlaySkipAdsRewardAnim(int count, Vector3 startPos)
	{
	}

	public void GiveReward(RewardType reward, int rewardAmount, int rewardSubIndex, CoinSource coinSource)
	{
	}

	private void AddCards(int amount, FlowerType flowerType)
	{
	}
}
