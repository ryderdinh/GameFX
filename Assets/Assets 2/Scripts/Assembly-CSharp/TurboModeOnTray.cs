using System.Collections.Generic;

public class TurboModeOnTray : BaseTrayBooster
{
	public TurboModeOnTray(ITrayBooster trayBooster)
		: base(null)
	{
	}

	public bool ApplyBooster(List<Tray> trays, bool activate)
	{
		return false;
	}
}
