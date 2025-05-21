using System.Collections.Generic;
using Analytics;
using DB;
using MS.Casual.Market;
using UnityEngine;

[CreateAssetMenu(fileName = "SeasonalProgressPassSystem", menuName = "ScriptableObjects/SeasonalProgressPassSystem/SeasonalProgressPassSystem")]
public class SeasonalProgressPassSystem : ScriptableObject, IIApp
{
	[SerializeField]
	private LiveOpsSystem _liveOpsSystem;

	public int TotalNumberOfMissions;

	[SerializeField]
	private int _eventPeriodInSecs;

	[SerializeField]
	private DBInt _dbMatchesSeasonProgress;

	[SerializeField]
	private DBInt _dbPreviousMatchesSeasonProgress;

	[SerializeField]
	private DBBool _dbSPPTutorialShown;

	[SerializeField]
	private DBBool _dbIsPassPurchased;

	[SerializeField]
	private RewardController _rewardController;

	[SerializeField]
	private MarketItemData _bloomPassOffer;

	[SerializeField]
	private SeasonalProgressController _normalSeasonProgress;

	[SerializeField]
	private SeasonalProgressController _premiumSeasonProgress;

	[SerializeField]
	private BloomPassNoAdsPerk _bloomPassNoAdsPerk;

	[SerializeField]
	private AnalyticsSystem _analyticsSystem;

	[SerializeField]
	private string[] _keysToDelete;

	public List<MatchesProgressMissionSPP> MatchesProgressMissionSPP;

	private int _matchesSeasonProgress;

	private int _lastProgressScore;

	private bool _sppTutorialShown;

	private bool _isPassPurchased;

	private Dictionary<RewardType, int> _rewards;

	private IAPHandler _iapHandler;

	private MonoBehaviour _coroutineRunner;

	private ILiveOps _liveOpsHandler;

	public bool IsPassPurchased => false;

	public int LastProgressScore => 0;

	public int CurrentMatchesProgress => 0;

	public int PreviousMatchesProgress => 0;

	public int NumberOfMission => 0;

	public void SetPreviousMatchesProgress()
	{
	}

	public int GetRemainingTime()
	{
		return 0;
	}

	public int GetMissionToFocus()
	{
		return 0;
	}

	public void Initialize(MonoBehaviour coroutineRunner, ILiveOps liveOps)
	{
	}

	private void InitializeValues()
	{
	}

	private void PassPurchased()
	{
	}

	public bool IsClaimable(int target)
	{
		return false;
	}

	public void UpdateProgress(int matches)
	{
	}

	public bool GiveReward(int id, RewardType missionReward, int rewardAmount, int rewardSubIndex, SPPRewardType sppRewardType)
	{
		return false;
	}

	public void PlayRewardAnimation()
	{
	}

	public bool CanShowNotification()
	{
		return false;
	}

	public bool IsUnclaimedRewardAvailable()
	{
		return false;
	}

	private bool HasUnclaimedRewards(int numberOfRewards)
	{
		return false;
	}

	public bool CanShowTutorial()
	{
		return false;
	}

	public void TutorialShown()
	{
	}

	public void PurchaseBloomPass()
	{
	}

	public void PurchaseSuccessfull(bool isRestore)
	{
	}

	public void PurchaseFailed()
	{
	}

	private void InitializeInApp()
	{
	}

	public void Reset()
	{
	}

	private void ClearOldKeys()
	{
	}
}
