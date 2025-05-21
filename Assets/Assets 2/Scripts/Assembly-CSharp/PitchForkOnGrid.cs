using System.Collections.Generic;
using UnityEngine;

public class PitchForkOnGrid : BaseGridBooster
{
	private int _slotsToRemoveCount;

	public PitchForkOnGrid(IGridBooster gridBooster)
		: base(null)
	{
	}

	public void ApplyBooster(List<Slot> slots)
	{
	}

	private void Shear(List<int> indexes, List<Slot> slots)
	{
	}

	private void PlayShearSequence(Slot slot, Dish dish, float delay = 0f)
	{
	}

	private void AddForceToPot(Rigidbody rb)
	{
	}

	private void AddPetalsForce(List<Rigidbody> rb)
	{
	}
}
