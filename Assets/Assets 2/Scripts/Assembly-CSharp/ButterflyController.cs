using DB;
using UnityEngine;

public class ButterflyController : BaseBoosterProvider
{
	[SerializeField]
	private ButterflyRefs _butterflyRefs;

	[SerializeField]
	private CashObject _cashObject;

	[SerializeField]
	private GameObject _butterflyObject;

	[SerializeField]
	private UserJourneySystem _userJourneySystem;

	[SerializeField]
	private MetaWorldConfig _worldConfig;

	[SerializeField]
	private LevelSystem _levelSystem;

	[SerializeField]
	private SkipAdsObject _skipAdsObject;

	[SerializeField]
	private ButterflyRewardController _butterflyRewardController;

	[SerializeField]
	private RemoteAppConfig _remoteConfig;

	[SerializeField]
	private DBInt _dBSpawningCount;

	[SerializeField]
	private DBBool _dBButterflyUnlocked;

	[SerializeField]
	private DBBool _dBIsButterflyNewFlow;

	private ButterflyConfigs _butterflyConfigs;

	private Vector3[] _pathPositions;

	private IButterfly _butterflyHandler;

	private Transform _destinationPoint;

	private ButterflyState _butterflyState;

	private ButterflyView _butterflyViewRefs;

	private float _timeRemaning;

	private float _movementSpeedMultiplier;

	private ButterflyTutorialController _butterflyTutorialController;

	private bool _isPasued;

	private int _spawningCount;

	private int _rewardCount;

	private int _butterfliesForLevel;

	private float _butterflyTargetDelta;

	private float _butterflyTargetScore;

	private bool _takeDeltaIntoAccount;

	private bool _blinking;

	private bool _butterflyUnlocked;

	private static readonly int EmissionColor;

	public override void Initialize(IBaseBoosterProvider baseBoosterProvider)
	{
	}

	private void RegisterEvents()
	{
	}

	public override void LoadData()
	{
	}

	private void OnLevelUp(LevelUpData levelUpData)
	{
	}

	private void SetTargetScoresOnLevelUpdate(bool onLevelUp = false)
	{
	}

	private int GetRewardCount()
	{
		return 0;
	}

	private void SetTargetScoreToTrigger()
	{
	}

	private void OnStartGame()
	{
	}

	private void LevelReset()
	{
	}

	public override void StartProcessing()
	{
	}

	private void SpawnButterfly()
	{
	}

	public override void UpdateState(float deltaTime, float fixedDeltaTime)
	{
	}

	private void ExecuteState(float deltaTime, float fixedDeltaTime)
	{
	}

	private void SetButterflyWarningMaterial()
	{
	}

	private Color GetEmissionColor(Material material, float emissionValue)
	{
		return default(Color);
	}

	private void ResetButterflyMaterial()
	{
	}

	private void Move(float deltaTime, float distance)
	{
	}

	private void CalculateNextPoint()
	{
	}

	protected override void CheckActivation()
	{
	}

	protected override void ActivateSpecialBooster()
	{
	}

	private void SetState(ButterflyState state)
	{
	}

	private void SetDefaultPosition()
	{
	}

	protected override void ExecuteSpecialBooster()
	{
	}

	private void ExecutionComplete()
	{
	}

	private void ButterflyNewFlow()
	{
	}

	private void ButterflyOldFlow()
	{
	}

	private void Exit()
	{
	}

	private void OnBoosterActivated(BoosterActivationDataModel boostersTypes)
	{
	}

	private void OnBoosterExecuted(BoostersTypes boostersTypes)
	{
	}

	private void OnBoosterClosed()
	{
	}

	private void SetButterflyState(bool state)
	{
	}

	protected override void Reset()
	{
	}

	private void MatchMade(float score)
	{
	}

	private bool OnGetButterflyUnlockedEvent()
	{
		return false;
	}
}
