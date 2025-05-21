using DB;
using UnityEngine;

[CreateAssetMenu(fileName = "GiftSpawnerObject", menuName = "ScriptableObjects/GiftSpawnerObject")]
public class GiftSpawnerSystem : ScriptableObject
{
	[SerializeField]
	private LevelSystem _levelSystem;

	[SerializeField]
	private MetaWorldConfig _worldConfig;

	[SerializeField]
	private int _giftSpawnFtueLevel;

	[SerializeField]
	private DBInt _dbCurrentRewardIndex;

	[SerializeField]
	private DBInt _dbRewardsSpawnedCount;

	[SerializeField]
	private int[] _rewardIndexChangeThreshold;

	[SerializeField]
	private ResourcesTexture[] _giftBoxTextures;

	[SerializeField]
	private float[] _giftBoxScales;

	[SerializeField]
	private int[] _giftRewardCount;

	private int _rewardsSpawned;

	private int _currentRewardIndex;

	public void Initialize()
	{
	}

	private void RegisterEvents()
	{
	}

	public ResourcesTexture GetCurrentGiftTexture()
	{
		return null;
	}

	public float GetCurrentGiftScale()
	{
		return 0f;
	}

	public int GetCurrentGiftReward()
	{
		return 0;
	}

	public void GiftSpawned()
	{
	}

	private void OnFailGameEvent()
	{
	}

	private bool IsFTUEActive()
	{
		return false;
	}

	private void SetDBCurrentRewardIndex(int value)
	{
	}

	private void SetDBRewardsSpawnedCount(int value)
	{
	}

	public bool IsGiftStreakAvailable()
	{
		return false;
	}
}
