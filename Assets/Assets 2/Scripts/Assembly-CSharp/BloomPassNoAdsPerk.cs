using Analytics;
using DB;
using MS.Casual.Ads;
using UnityEngine;

[CreateAssetMenu(fileName = "BloomPassNoAdsPerk", menuName = "ScriptableObjects/SeasonalProgressPassSystem/BloomPassNoAdsPerk")]
public class BloomPassNoAdsPerk : ScriptableObject
{
	[SerializeField]
	private bool _canGivePerk;

	[SerializeField]
	private int _worldToActivatePerk;

	[SerializeField]
	private int _intersToActivatePerk;

	[SerializeField]
	private int _perkIndex;

	[SerializeField]
	private DBBool _perkActivated;

	[SerializeField]
	private MetaSystem _metaSystem;

	[SerializeField]
	private UserJourneySystem _userJourneySystem;

	[SerializeField]
	private RemoveAdsObject _removeAdsObject;

	[SerializeField]
	private SeasonalProgressPassSystem _seasonalProgressPassSystem;

	[SerializeField]
	private AnalyticsSystem _analyticsSystem;

	private bool _isPerkActive;

	public int PerkIndex => 0;

	public bool IsPerkActive => false;

	public void Initialize()
	{
	}

	public bool CanGivePerk()
	{
		return false;
	}

	public bool ActivatePerk(int index)
	{
		return false;
	}

	public void ResetPerk()
	{
	}
}
