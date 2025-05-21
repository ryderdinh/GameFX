using System.Collections.Generic;

public abstract class BaseGridBooster
{
	protected bool _IsBoosterInProgress;

	protected IGridBooster _GridBooster;

	public BaseGridBooster(IGridBooster gridBooster)
	{
	}

	public bool IsBoosterInProgress()
	{
		return false;
	}

	public void SetBoosterState(bool state)
	{
	}

	protected void ForceCompleteFlowerAndExecutionInPart(Queue<int> indexes, List<Slot> slots, BoostersTypes boostersType)
	{
	}

	protected void Rocket(List<int> indexes, List<Slot> slots)
	{
	}
}
