using System.Collections.Generic;

public class DishTierUpdateOnTray : BaseTrayBooster
{
	public DishTierUpdateOnTray(ITrayBooster trayBooster)
		: base(null)
	{
	}

	public bool ApplyBooster(List<Tray> trays)
	{
		return false;
	}
}
