using System.Collections.Generic;
using UnityEngine;

public class MagicPotOnGrid : BaseGridBooster
{
	private int _cakeID;

	private int _cakesToRemoveCount;

	public MagicPotOnGrid(IGridBooster gridBooster)
		: base(null)
	{
	}

	public void ApplyBooster(List<Slot> slots, int cakeID, Neighbours neighbors, Collider[] boingColliders)
	{
	}

	private void PrioritizeEqualOrLess(List<Slot> tempSlots, List<Slot> cleaningSlots, int cakesCount)
	{
	}

	private void UseRestOfThem(List<Slot> tempSlots, List<Slot> cleaningSlots, int cakesCount)
	{
	}
}
