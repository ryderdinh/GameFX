using System.Collections.Generic;

public class DishTierUpdateOnGrid : BaseGridBooster
{
	public DishTierUpdateOnGrid(IGridBooster gridBooster)
		: base(null)
	{
	}

	public bool ApplyBooster(List<Slot> slots)
	{
		return false;
	}
}
