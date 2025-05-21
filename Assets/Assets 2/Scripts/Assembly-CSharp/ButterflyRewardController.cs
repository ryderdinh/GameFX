using DB;
using UnityEngine;

[CreateAssetMenu(fileName = "ButterflyRewardObject", menuName = "Butterfly")]
public class ButterflyRewardController : BoosterDropSystem
{
	[SerializeField]
	private int _butterflyFreeRewardCount;

	[SerializeField]
	private BoosterProbabilityLevelsConfigs _boosterProbabilityLevelsConfigs;

	[SerializeField]
	private UserJourneySystem _userJourneySystem;

	[SerializeField]
	private DBInt _freeSpinData;

	[SerializeField]
	private ButterflySpinnerConfigs _butterflySpinnerConfigs;

	[SerializeField]
	private DBBool _dbBoolBoosterDropObjectTutorialShown;

	[SerializeField]
	[Tooltip("in seconds")]
	private float _dropTutorialWait;

	[SerializeField]
	private SkipAdsObject _skipAdsObject;

	private int _selectedIndex;

	private bool _isFTUE;

	private int _freeRewardCount;

	private bool _boosterDropTutorialShown;

	private BoosterProbabilityGenerator _boosterProbabilityGenerator;

	public float DropTutorialWait => 0f;

	public override void Initialize(IBaseBoosterProvider boosterProvider)
	{
	}

	public void LoadButterflyReward()
	{
	}

	public void DropButterflyReward(Vector3 butterflyPosition)
	{
	}

	public bool IsBoosterDropObjectTutorialShown()
	{
		return false;
	}

	public void BoosterDropObjectTutorialCompleted()
	{
	}

	public void BoosterDropObjectTutorialActivated()
	{
	}

	private void InitializeEvents()
	{
	}

	private void OnButterflyDropDespawnTimeUpdateEvent(int time)
	{
	}

	private void OnUpdateBoosterDropConfigEvent(BoosterDropConfig config)
	{
	}

	private void LoadFreeRewardCount()
	{
	}

	private void SaveFreeRewardCount(int value)
	{
	}

	private void CheckForFTUE()
	{
	}

	private void GetRewardBoostersTypes()
	{
	}

	private void CalculateBoosterProbabilityFromRange()
	{
	}

	private void LoadBoosterDropObjectTutorial()
	{
	}

	private void SaveBoosterDropObjectTutorial()
	{
	}

	private void SpawnSpecifiedBooster()
	{
	}
}
