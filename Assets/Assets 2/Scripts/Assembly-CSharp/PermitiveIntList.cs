using MSKit.ResourcePool;

public class PermitiveIntList : PrimitiveListPool<int>
{
	public PermitiveIntList(int initialSize = 0, int maxSize = 10)
		: base(0, 0)
	{
	}
}
