using System.Collections.Generic;
using UnityEngine;

public class BombOnGrid : BaseGridBooster
{
	public BombOnGrid(IGridBooster gridBooster)
		: base(null)
	{
	}

	public void ApplyBooster(Slot slot, List<Slot> slots, int columns, int rows)
	{
	}

	private void PlayShearSequence(Slot slot, Dish dish, float delay = 0f, float duration = 0.25f)
	{
	}

	private void AddPetalsForce(List<Rigidbody> rb)
	{
	}

	private List<Slot> GetSlots(Slot slot, List<Slot> slots, int columns, int rows)
	{
		return null;
	}
}
