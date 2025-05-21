using System.Collections.Generic;

public class FlowerTierUpdateOnTray : BaseTrayBooster
{
	public FlowerTierUpdateOnTray(ITrayBooster trayBooster)
		: base(null)
	{
	}

	public bool ApplyBooster(List<Tray> trays, int flowerID, float moveTraysToNormalStateDelay)
	{
		return false;
	}
}
