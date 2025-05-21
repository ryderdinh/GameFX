using System.Collections.Generic;
using DB;

public static class CustomGridSort
{
	private static float _normalizer;

	private static GridConfig _gridConfigs;

	private static SortDirection _neighboursDirection;

	private static readonly List<Dictionary<int, SlotData>> _allPossibleStates;

	private static readonly List<List<MovementData>> _allMoves;

	private static readonly List<float> _scoresList;

	private static readonly List<int> _uniqueItemIdsInSlots;

	private static readonly List<int> _redundantMoves;

	private static readonly List<int> _slotsInLoop;

	private static readonly List<VisitedSlotData> _predecessors;

	private static readonly List<VisitedSlotData> _lockedSlots;

	private static readonly List<int> _neighbours;

	private static ArrayArrayInt _gridState;

	public static void Initialize()
	{
	}

	public static List<MovementData> SortGrid(ArrayArrayInt gridState, List<int> masterCells)
	{
		return null;
	}

	private static void UpdateGridState(int cellId, Dictionary<int, SlotData> slotData)
	{
	}

	private static int GetBestState(List<Dictionary<int, SlotData>> allStates, List<List<MovementData>> moves)
	{
		return 0;
	}

	private static List<MovementData> RemoveRedundantMoves(List<MovementData> movements)
	{
		return null;
	}

	private static void MoveItem(List<VisitedSlotData> predecessors, List<VisitedSlotData> lockedSlots, List<int> slotsInLoop, int masterCellId, int masterItemId, int itemToFind, Dictionary<int, SlotData> gridState, bool forcePull, List<MovementData> moves)
	{
	}

	private static void FindItem(List<VisitedSlotData> predecessors, List<VisitedSlotData> lockedSlots, List<int> slotsInLoop, SlotData masterCell, int itemToFind, int masterCellId, int masterItemId, Dictionary<int, SlotData> gridState, bool forcePull, List<MovementData> moves)
	{
	}

	private static void MoveItems(int masterCellId, int neighbourId, int uniqueItemId, bool pullItems, List<VisitedSlotData> predecessors, List<VisitedSlotData> lockedSlots, Dictionary<int, SlotData> gridState, List<int> slotsInLoop, List<MovementData> moves)
	{
	}

	private static List<int> GetNeighboursWithItem(int slotId, int itemId, Dictionary<int, SlotData> gridState, bool updateState = true)
	{
		return null;
	}
}
