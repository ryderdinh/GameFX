using System.Collections.Generic;

public struct PassiveBoosterData
{
	public List<int> Items;

	public PassiveBoosterType Type;

	public PassiveBoosterCategory Category;

	public int Count;

	public long ExpireTime;

	public double remainingTime;

	public PassiveBoosterData(List<int> items, PassiveBoosterType type, int count, long expireTime, PassiveBoosterCategory category)
	{
		Items = null;
		Type = default(PassiveBoosterType);
		Category = default(PassiveBoosterCategory);
		Count = 0;
		ExpireTime = 0L;
		remainingTime = 0.0;
	}
}
