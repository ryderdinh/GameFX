using System.Collections.Generic;
using DB;
using UnityEngine;

public class SwapSlotsOnGrid : BaseGridBooster
{
	private readonly RaycastHit[] _raycastResults;

	private LayerMask _layerMask;

	private Vector3 _targetPosition;

	private DishConfig _dishConfigs;

	private IBoing _boingHandler;

	private int _movingSlotID;

	public SwapSlotsOnGrid(IBoing boingHandler, IGridBooster gridBooster)
		: base(null)
	{
	}

	public void MoveSlot(Camera mainCamera, List<Slot> slots)
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

	private bool SnapSlotOnGrid(List<Slot> slots)
	{
		return false;
	}

	private void MoveBoingCollider(Vector3 position)
	{
	}

	private int[] CopySlotData(ArrayInt slotData)
	{
		return null;
	}
}
