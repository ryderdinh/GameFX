using System.Collections.Generic;

public class TrayBoostersController
{
	private readonly Dictionary<BoostersTypes, BaseTrayBooster> _trayBoosters;

	private SmallFertilizerOnTrays _smallFertilizerOnTrays;

	private LargeFertilizerOnTray _largeFertilizerOnTray;

	private FlowerTierUpdateOnTray _flowerTierUpdateOnTray;

	private DishTierUpdateOnTray _dishTierUpdateOnTray;

	private TurboModeOnTray _turboModeOnTray;

	public TrayBoostersController(ITrayBooster trayBooster)
	{
	}

	public void ApplySmallFertilizer(TraySpawnerObject traySpawnerObject, Tray tray)
	{
	}

	public void ApplyLargeFertilizer(TraySpawnerObject traySpawnerObject, List<Tray> trays)
	{
	}

	public bool ApplyFlowerTierUpdate(List<Tray> trays, int flowerId, float delay)
	{
		return false;
	}

	public bool ApplyDishTierUpdate(List<Tray> trays)
	{
		return false;
	}

	public bool ApplyTurboMode(List<Tray> trays, bool activate)
	{
		return false;
	}

	public bool IsBoosterInProgress(BoostersTypes booster)
	{
		return false;
	}

	public void UpdateBoosterState(BoostersTypes booster, bool state)
	{
	}

	public bool AnyTrayBoosterInProgress()
	{
		return false;
	}
}
