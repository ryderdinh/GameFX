using System;

[Serializable]
public class ValueRange
{
	public float MinValue;

	public float MaxValue;

	public ValueRange(float min = 0f, float max = 0f)
	{
	}

	public float GetRandomValue()
	{
		return 0f;
	}
}
