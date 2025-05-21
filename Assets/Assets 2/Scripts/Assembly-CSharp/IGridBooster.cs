using System.Collections.Generic;

public interface IGridBooster
{
	void WaterCanApplied();

	void SuperWaterCanApplied();

	void HorizontalRocketApplied();

	void VerticalRocketApplied();

	void HorizontalVerticalRocketApplied();

	void BombApplied(float delay);

	void RowSortApplied();

	void ColumnSortApplied();

	void PitchForkApplied();

	void TrovelApplied();

	void PaintBrushApplied(Slot slot);

	void MagicPotApplied();

	void SuperMagicPotApplied();

	void CustomSortGrid(List<MovementData> moves, bool isSafeCheck);

	void WheelBarrowExecuted(float time);

	void SlotUnlockApplied(int id);

	void SaveGridData();

	void MoveSlot(List<Dish> dishes);

	void UnhighlightPreviousTiles();

	void ReplaceAndSortGrid(List<int> indexes, List<Dish> dishes);

	List<int> CalculateSlotIndexes(List<Dish> dishes);

	void SwapSlotCompleted();

	void SexyPotApplied();
}
