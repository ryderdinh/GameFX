using System.Collections.Generic;

public class TurboModeOnGrid : BaseGridBooster
{
	public TurboModeOnGrid(IGridBooster gridBooster)
		: base(null)
	{
	}

	public bool ApplyBooster(List<Slot> slots, bool activate)
	{
		return false;
	}
}
