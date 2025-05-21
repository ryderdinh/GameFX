using DB;
using UnityEngine;

[CreateAssetMenu(fileName = "BoosterSelectionCalculationObject", menuName = "Game/BoosterSelectionCalculationObject")]
public class BoosterSelectionCalculationObject : ScriptableObject
{
	[SerializeField]
	private SlotsStateObject _slotsStateObject;

	[SerializeField]
	private DBString _dbTraysState;

	[SerializeField]
	private DishSpawnerObject _dishSpawnerObject;

	[SerializeField]
	private GridDataObject _gridDataObject;

	[SerializeField]
	private DishUpgradableObject _dishUpgradableObject;

	[SerializeField]
	private AllItemsObject _allItemsObject;

	[SerializeField]
	private GridConfig _gridConfig;

	public BoosterSelectionData GetWaterCanSelectionData()
	{
		return default(BoosterSelectionData);
	}

	public BoosterSelectionData GetSuperWaterCanSelectionData()
	{
		return default(BoosterSelectionData);
	}

	public BoosterSelectionData GetHorizontalShearSelectionData(BoosterSelectionCriteria selectionCriteria)
	{
		return default(BoosterSelectionData);
	}

	public BoosterSelectionData GetVerticalShearSelectionData(BoosterSelectionCriteria selectionCriteria)
	{
		return default(BoosterSelectionData);
	}

	public BoosterSelectionData GetRowWindBlowerSelectionData(BoosterSelectionCriteria selectionCriteria)
	{
		return default(BoosterSelectionData);
	}

	public BoosterSelectionData GetColumnWindBlowerSelectionData(BoosterSelectionCriteria selectionCriteria)
	{
		return default(BoosterSelectionData);
	}

	public BoosterSelectionData GetTrovelSelectionData(BoosterSelectionCriteria selectionCriteria)
	{
		return default(BoosterSelectionData);
	}

	public BoosterSelectionData GetLargeFertilizerSelectionData()
	{
		return default(BoosterSelectionData);
	}

	public BoosterSelectionData GetDishUpgradeSelectionData()
	{
		return default(BoosterSelectionData);
	}

	public BoosterSelectionData GetFlowerUpgradeSelectionData(int flowerId)
	{
		return default(BoosterSelectionData);
	}

	public BoosterSelectionData GetSexyPotSelectionData()
	{
		return default(BoosterSelectionData);
	}

	public BoosterSelectionData GetWaterCanSelectionData(TrayType trayType)
	{
		return default(BoosterSelectionData);
	}

	private BoosterSelectionData GetWaterCanSlot(TrayType trayType)
	{
		return default(BoosterSelectionData);
	}

	public BoosterSelectionData GetWheelBarrowSelectionData(BoosterSelectionCriteria selectionCriteria)
	{
		return default(BoosterSelectionData);
	}

	public BoosterSelectionData GetPitchForkSelectionData(BoosterSelectionCriteria selectionCriteria)
	{
		return default(BoosterSelectionData);
	}

	public BoosterSelectionData GetBombSelectionData(BoosterSelectionCriteria selectionCriteria)
	{
		return default(BoosterSelectionData);
	}

	public BoosterSelectionData GetSmallFertilizerSelectionData(BoosterSelectionCriteria selectionCriteria)
	{
		return default(BoosterSelectionData);
	}

	public BoosterSelectionData GetSuperMagicPotSelectionData(int flowerId, BoosterSelectionCriteria selectionCriteria)
	{
		return default(BoosterSelectionData);
	}

	public BoosterSelectionData GetMagicPotSelectionData(int flowerId, BoosterSelectionCriteria selectionCriteria)
	{
		return default(BoosterSelectionData);
	}

	public BoosterSelectionData GetSlotUnlockSelectionData(BoosterSelectionCriteria selectionCriteria)
	{
		return default(BoosterSelectionData);
	}

	public BoosterSelectionData GetPaintBrushSelectionData(int flowerId, BoosterSelectionCriteria criteria)
	{
		return default(BoosterSelectionData);
	}

	public BoosterSelectionData GetSwapSlotsSelectionData(BoosterSelectionCriteria criteria)
	{
		return default(BoosterSelectionData);
	}

	private int GetPetalCount(int flowerId)
	{
		return 0;
	}

	private BoosterSelectionData GetRandomSlot()
	{
		return default(BoosterSelectionData);
	}

	private BoosterSelectionData GetMostCoveredSlot()
	{
		return default(BoosterSelectionData);
	}

	private int GetAvailableSlotsCount()
	{
		return 0;
	}

	private int GetOccupiedSlotsCount()
	{
		return 0;
	}

	private int GetRandomAvailableSlot()
	{
		return 0;
	}

	private int GetOccupiedSlotsCount(int totalIterations, int deltaInStartIndex, int deltaInEndIndex, int deltaInIterations)
	{
		return 0;
	}

	private BoosterSelectionData GetBestSelectionForDirectionalBooster(int totalIterations, int deltaInStartIndex, int deltaInEndIndex, int deltaInIterations, BoosterSelectionCriteria selectionCriteria, int minOccupied)
	{
		return default(BoosterSelectionData);
	}

	private BoosterSelectionData GetBestSelectionForSortingBooster(int totalIterations, int deltaInStartIndex, int deltaInEndIndex, int deltaInIterations, BoosterSelectionCriteria selectionCriteria, int minMatches)
	{
		return default(BoosterSelectionData);
	}
}
