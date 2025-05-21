using System.Collections.Generic;

public class FlowerTierUpdateOnGrid : BaseGridBooster
{
	public FlowerTierUpdateOnGrid(IGridBooster gridBooster)
		: base(null)
	{
	}

	public void AddCards(int flowerId, int cards)
	{
	}

	public bool ApplyBooster(List<Slot> slots, int flowerID)
	{
		return false;
	}
}
