using System.Collections.Generic;
using DB;
using UnityEngine;

[CreateAssetMenu(fileName = "SmartBoosterSelectionObject", menuName = "Game/SmartBoosterSelectionObject")]
public class SmartBoosterSelectionObject : ScriptableObject
{
	[SerializeField]
	private DBString _appliedBoostersData;

	[SerializeField]
	private DBInt _totalFlowerUpgradeAppliedData;

	[SerializeField]
	private DBInt _totalDishUpgradeAppliedData;

	[SerializeField]
	private DBInt _totalSlotUnlockAppliedData;

	[SerializeField]
	private SlotsStateObject _slotsStateObject;

	[SerializeField]
	private AllItemsObject _allItemsObject;

	[SerializeField]
	private GridDifficultyCalculator _gridDifficultyCalculator;

	[SerializeField]
	private DishUpgradableObject _dishUpgradableObject;

	[SerializeField]
	private DishSpawnerObject _dishSpawnerObject;

	[SerializeField]
	private GridDataObject _gridDataObject;

	[SerializeField]
	private int _gridActiveBoosterScore;

	[SerializeField]
	private BoosterSelectionCalculationObject _boosterSelectionCalculationObject;

	private List<int> _petalsList;

	private List<BoostersTypes> _appliedBoostersList;

	private int _totalFlowerUpgradeAppliedCount;

	private int _totalDishUpgradeAppliedCount;

	private int _totalSlotUnlockAppliedCount;

	private void OnEnable()
	{
	}

	private void Initialize()
	{
	}

	private void RegisterEvents()
	{
	}

	public bool GridNeedsActiveBooster()
	{
		return false;
	}

	public int GetDishTierId()
	{
		return 0;
	}

	private bool CanGiveSexyPot()
	{
		return false;
	}

	private bool CanGiveDishTierUpgrade()
	{
		return false;
	}

	private bool CanGiveWaterCan()
	{
		return false;
	}

	private bool CanGiveSuperWaterCan()
	{
		return false;
	}

	private bool CanGiveSwapSlots(BoosterSelectionCriteria selectionCriteria)
	{
		return false;
	}

	private bool CanGiveBomb(BoosterSelectionCriteria selectionCriteria)
	{
		return false;
	}

	private bool CanGivePitchFork(BoosterSelectionCriteria selectionCriteria)
	{
		return false;
	}

	private bool CanGiveTrovel(BoosterSelectionCriteria selectionCriteria)
	{
		return false;
	}

	private bool CanGiveWheelBarrow(BoosterSelectionCriteria selectionCriteria)
	{
		return false;
	}

	private bool CanGiveHorizontalShear(BoosterSelectionCriteria selectionCriteria)
	{
		return false;
	}

	private bool CanGiveVerticalShear(BoosterSelectionCriteria selectionCriteria)
	{
		return false;
	}

	private bool CanGiveRowWindBlower(BoosterSelectionCriteria selectionCriteria)
	{
		return false;
	}

	private bool CanGiveColumnWindBlower(BoosterSelectionCriteria selectionCriteria)
	{
		return false;
	}

	private bool CanGiveSmallFertilizer(BoosterSelectionCriteria selectionCriteria)
	{
		return false;
	}

	private bool CanGiveLargeFertilizer()
	{
		return false;
	}

	private bool CanGiveSlotUnlock(BoosterSelectionCriteria selectionCriteria)
	{
		return false;
	}

	private bool CanGiveSuperMagicPot(BoosterSelectionCriteria selectionCriteria)
	{
		return false;
	}

	private bool CanGiveMagicPot(BoosterSelectionCriteria selectionCriteria)
	{
		return false;
	}

	private bool CanGivePaintBrush(BoosterSelectionCriteria selectionCriteria)
	{
		return false;
	}

	public BoostersTypes GetBestBooster()
	{
		return default(BoostersTypes);
	}

	public bool CanGiveBooster(BoostersTypes boostersTypes, bool isExtremeIntelligent = false, bool isFTUE = false)
	{
		return false;
	}

	public List<int> GetFlowerToUpgrade()
	{
		return null;
	}

	public List<int> GetBestPossibleDish()
	{
		return null;
	}

	private void BoosterExecuted(BoostersTypes boostersTypes)
	{
	}

	public List<BoostersTypes> GetAppliedBoosterList()
	{
		return null;
	}

	public int GetTotalFlowerUpgradeApplied()
	{
		return 0;
	}

	public int GetTotalDishUpgradeApplied()
	{
		return 0;
	}

	public int GetTotalSlotUnlockApplied()
	{
		return 0;
	}
}
