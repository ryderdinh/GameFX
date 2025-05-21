using System.Collections.Generic;
using UnityEngine;

public class VerticalRocketOnGrid : BaseGridBooster
{
	public VerticalRocketOnGrid(IGridBooster gridBooster)
		: base(null)
	{
	}

	public void ApplyBooster(Slot slot, List<Slot> slots, int columns, int rows)
	{
	}

	private void Shear(List<int> indexes, List<Slot> slots)
	{
	}

	private void PlayShearSequence(Slot slot, Dish dish, float delay = 0f)
	{
	}

	private void AddPetalsForce(List<Rigidbody> rb)
	{
	}
}
