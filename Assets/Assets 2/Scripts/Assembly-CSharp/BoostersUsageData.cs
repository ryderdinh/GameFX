using System;
using DB;

[Serializable]
public struct BoostersUsageData
{
	public BoostersTypes Type;

	public DBInt OfferedCount;

	public DBInt AvailedCount;

	public void BoosterOffered()
	{
	}

	public void BoosterAvailed()
	{
	}

	public void Reset()
	{
	}
}
