using DB;
using UnityEngine;

[CreateAssetMenu(fileName = "SkipAdsObject", menuName = "ScriptableObjects/SkipAdsObject")]
public class SkipAdsObject : ScriptableObject
{
	[SerializeField]
	private DBInt _dbSkipAds;

	[SerializeField]
	private DBInt _dbSkipAdsNotifyCount;

	[SerializeField]
	private DBInt _dbFrequencyIndex;

	[SerializeField]
	private int[] _skipAdsNotifyFrequency;

	private int _skipAdsCount;

	private int _skipFrequencyIndex;

	private int _skipAdsNotifyCount;

	public int TotalSkipAds => 0;

	public void Initialize()
	{
	}

	public void AddSkipAds(int count)
	{
	}

	public bool DeductSkipAds(int count = 1)
	{
		return false;
	}

	public void IncrementSkipAdsNotifyValue()
	{
	}

	private void SaveSkipAdsNotifyValue()
	{
	}

	private void SaveSkipAdsFrequencyIndex()
	{
	}

	public bool CanSkipAd()
	{
		return false;
	}

	public bool IsNeedToNotify()
	{
		return false;
	}

	public int GetSkipAdsOfferCount()
	{
		return 0;
	}

	private int GetClampedFrequencyIndex()
	{
		return 0;
	}

	private void NotifiedSkipAdsPurchase()
	{
	}
}
