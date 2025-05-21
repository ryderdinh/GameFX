using System.Collections.Generic;
using DB;
using UnityEngine;

public class GridBoostersController
{
	private readonly Dictionary<BoostersTypes, BaseGridBooster> _gridBoosters;

	private WaterCanOnGrid _waterCanOnGrid;

	private SuperWaterCanOnGrid _superWaterCanOnGrid;

	private SwapSlotsOnGrid _swapSlotsOnGrid;

	private HorizontalRocketOnGrid _horizontalRocketOnGrid;

	private VerticalRocketOnGrid _verticalRocketOnGrid;

	private HorizonntalVerticalRocketOnGrid _horizonntalVerticalRocketOnGrid;

	private BombOnGrid _bombOnGrid;

	private RowSortOnGrid _rowSortOnGrid;

	private PitchForkOnGrid _pitchForkOnGrid;

	private TrovelOnGrid _trovelOnGrid;

	private PaintBrushOnGrid _paintBrushOnGrid;

	private MagicPotOnGrid _magicPotOnGrid;

	private SuperMagicPotOnGrid _superMagicPotOnGrid;

	private ColumnSortOnGrid _columnSortOnGrid;

	private WheelBarrowOnGrid _wheelBarrowOnGrid;

	private SlotUnlockOnGrid _slotUnlockOnGrid;

	private FlowerTierUpdateOnGrid _flowerTierUpdateOnGrid;

	private SexyPotOnGrid _sexyPotOnGrid;

	private DishTierUpdateOnGrid _dishTierUpdateOnGrid;

	private TurboModeOnGrid _turboModeOnGrid;

	private MonoBehaviour _coroutineRunner;

	public GridBoostersController(IBoing boing, IGridBooster gridBooster, MonoBehaviour mono)
	{
	}

	public void SetPaintBrushCakeID(int cakeID)
	{
	}

	public void ApplyWaterCan(Slot slot)
	{
	}

	public void ApplySuperWaterCan(Slot slot, List<Slot> slots)
	{
	}

	public void ApplyHorizontalRocket(Slot slot, List<Slot> slots, int columns, int rows)
	{
	}

	public void ApplyVerticalRocket(Slot slot, List<Slot> slots, int columns, int rows)
	{
	}

	public void ApplyHorizontalVerticalRocket(Slot slot, List<Slot> slots, int columns, int rows)
	{
	}

	public void ApplyBomb(Slot slot, List<Slot> slots, int columns, int rows)
	{
	}

	public void ApplyRowSort(Slot slot, List<Slot> slots, int columns, ArrayArrayInt slotsCurrentState)
	{
	}

	public void ApplyColumnSort(Slot slot, List<Slot> slots, int columns, int rows, ArrayArrayInt slotsCurrentState)
	{
	}

	public void ApplyPitchFork(List<Slot> slots)
	{
	}

	public void ApplyTrovel(Slot slot)
	{
	}

	public void ApplyPaintBrush(Slot slot)
	{
	}

	public void ApplyMagicPot(List<Slot> slots, int cakeID, Neighbours _neighbors, DishSpawnerObject dishSpawnerObject, Collider[] boingColliders)
	{
	}

	public void ApplySuperMagicPot(List<Slot> slots, int cakeID, Collider[] boingColliders)
	{
	}

	public void ApplyWheelBarrow(List<Slot> slots)
	{
	}

	public void ApplySlotUnlockBooster(Slot slot)
	{
	}

	public bool ApplyFlowerTierUpdate(List<Slot> slots, int flowerId)
	{
		return false;
	}

	public void AddFlowerTierUpdateCards(int flowerId, int cardsCount)
	{
	}

	public void ApplySexyPot(Slot slot, Dish dish)
	{
	}

	public bool ApplyDishTierUpdate(List<Slot> slots)
	{
		return false;
	}

	public bool ApplyTurboMode(List<Slot> slots, bool activate)
	{
		return false;
	}

	public bool IsBoosterInProgress(BoostersTypes booster)
	{
		return false;
	}

	public void UpdateBoosterState(BoostersTypes booster, bool state)
	{
	}

	public bool AnyGridBoosterInProgress()
	{
		return false;
	}

	public void ResetAllBoosters()
	{
	}

	public void MoveSlot(Camera camera, List<Slot> slots)
	{
	}

	public void SetMovingSlot(int id, List<Slot> slots)
	{
	}

	public bool SnapSlot(List<Slot> slots, bool canSnap)
	{
		return false;
	}

	public int MovingSlotID()
	{
		return 0;
	}
}
