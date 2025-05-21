using MSKit.ResourcePool;

public class IntListPool : GenericPool<IntList>
{
	public IntListPool(int initialSize = 0, int maxSize = 10)
		: base(0, 0)
	{
	}

	protected override IntList GetNewInstance()
	{
		return null;
	}
}
