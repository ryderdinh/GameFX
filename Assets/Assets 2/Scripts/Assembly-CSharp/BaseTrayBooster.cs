public abstract class BaseTrayBooster
{
	protected bool _IsBoosterInProgress;

	protected ITrayBooster _TrayBooster;

	public BaseTrayBooster(ITrayBooster trayBooster)
	{
	}

	public bool IsBoosterInProgress()
	{
		return false;
	}

	public void SetBoosterState(bool state)
	{
	}
}
