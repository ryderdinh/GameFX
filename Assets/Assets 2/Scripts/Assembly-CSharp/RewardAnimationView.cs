using System;
using MSKit.ResourcePool;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RewardAnimationView : MonoBehaviour
{
	[SerializeField]
	private RewardAnimationViewType _rewardAnimationViewType;

	[SerializeField]
	private TextMeshProUGUI _rewardAmountText;

	[SerializeField]
	private RectTransform _rewardTextRect;

	[SerializeField]
	private Transform _rewardTransform;

	[SerializeField]
	private Transform _rewardContainer;

	[SerializeField]
	private Transform _reward3D;

	[SerializeField]
	private Transform _reward2D;

	[SerializeField]
	private ParticleSystem _splashParticles;

	[SerializeField]
	private Image _rewardImage;

	[SerializeField]
	private Image _headerImage;

	[SerializeField]
	private Vector3 _initialPosition;

	[SerializeField]
	private Vector3 _targetPosition;

	private bool _is2DReward;

	private Transform _reward;

	private Vector3 _initialScale;

	private int _totalrewards;

	private Pool<Transform> _rewardsPool;

	public RewardAnimationViewType RewardAnimationViewType => default(RewardAnimationViewType);

	public void Initialize()
	{
	}

	public void PlayRewardAnimation(CollectablesData animData)
	{
	}

	public void PlayRewardAnimation(Sprite icon, CollectablesData animData)
	{
	}

	public void PlayRewardAnimation(Sprite icon, RewardType rewardType, CollectablesData animData)
	{
	}

	private void Start2DAnimation(Sprite icon)
	{
	}

	private void UpdateRewardAnimation(CollectablesData data)
	{
	}

	private void Play3DRewardAnimation(Transform rewardObject, Vector3 endPoint, float duration, Action callback, float delay = 0f, bool isWorld = false, float rewardsSpreadTime = 0.3f, float rewardsSpreadDistance = 200f, float delayAfterSpread = 0.1f, float rotation = 360f)
	{
	}

	private void Play2DRewardAnimation(Transform rewardObject, Vector3 endPoint, float duration, Action callback, float delay = 0f, bool isWorld = false, float rewardsSpreadTime = 0.3f, float rewardsSpreadDistance = 200f, float delayAfterSpread = 0.1f, float rotation = 360f)
	{
	}

	private void UpdateRewardCounter(int count)
	{
	}

	private void UpdateRewardsText(int count, RewardType rewardType = RewardType.None)
	{
	}
}
