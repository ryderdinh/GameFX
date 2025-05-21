using System.Collections.Generic;
using DB;

public class GridSort
{
	private float _normalizer;

	private GridConfig _gridConfigs;

	private SortDirection _neighboursDirection;

	private readonly List<Dictionary<int, SlotData>> _allPossibleStates;

	private readonly List<List<MovementData>> _allMoves;

	private readonly List<float> _scoresList;

	private readonly List<int> _uniqueItemIdsInSlots;

	private readonly List<int> _redundantMoves;

	private readonly List<int> _slotsInLoop;

	private readonly List<VisitedSlotData> _predecessors;

	private readonly List<VisitedSlotData> _lockedSlots;

	private ArrayArrayInt _gridState;

	private int _tempIndex;

	private int _tempCount;

	public List<MovementData> SortGrid(ArrayArrayInt gridState, List<int> masterCells)
	{
		return null;
	}

	private void UpdateGridState(int cellId, Dictionary<int, SlotData> slotData)
	{
	}

	private int GetBestState(List<Dictionary<int, SlotData>> allStates, List<List<MovementData>> moves)
	{
		return 0;
	}

	private List<MovementData> RemoveRedundantMoves(List<MovementData> movements)
	{
		return null;
	}

	private void MoveItem(List<VisitedSlotData> predecessors, List<VisitedSlotData> lockedSlots, List<int> slotsInLoop, int masterCellId, int masterItemId, int itemToFind, Dictionary<int, SlotData> gridState, bool forcePull, List<MovementData> moves)
	{
	}

	private bool HasItem(List<VisitedSlotData> data, int itemToFind)
	{
		return false;
	}

	private bool HasSlot(List<VisitedSlotData> data, int slotToFind)
	{
		return false;
	}

	private bool HasSlotAndItem(List<VisitedSlotData> data, int slotToFind, int itemToFind)
	{
		return false;
	}

	private bool HasSlotAndItemAndRevisit(List<VisitedSlotData> data, int slotToFind, int itemToFind)
	{
		return false;
	}

	private bool HasSlotAndItemAndNotRevisit(List<VisitedSlotData> data, int slotToFind, int itemToFind)
	{
		return false;
	}

	private MovementData HasMove(List<MovementData> data, int itemToFind, int moveFrom, int moveTo)
	{
		return default(MovementData);
	}

	private void FindItem(List<VisitedSlotData> predecessors, List<VisitedSlotData> lockedSlots, List<int> slotsInLoop, SlotData masterCell, int itemToFind, int masterCellId, int masterItemId, Dictionary<int, SlotData> gridState, bool forcePull, List<MovementData> moves)
	{
	}

	private void MoveItems(int masterCellId, int neighbourId, int uniqueItemId, bool pullItems, List<VisitedSlotData> predecessors, List<VisitedSlotData> lockedSlots, Dictionary<int, SlotData> gridState, List<int> slotsInLoop, List<MovementData> moves)
	{
	}

	private List<int> GetNeighbours(int slotId)
	{
		return null;
	}

	private List<int> GetNeighboursWithItem(int slotId, int itemId, Dictionary<int, SlotData> gridState, bool updateState = true)
	{
		return null;
	}
}
