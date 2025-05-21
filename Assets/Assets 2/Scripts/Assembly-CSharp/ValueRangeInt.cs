using System;

[Serializable]
public class ValueRangeInt
{
	public int MinValue;

	public int MaxValue;

	public ValueRangeInt(int min = 0, int max = 0)
	{
	}

	public int GetRandomValue()
	{
		return 0;
	}
}
