using System;

[Serializable]
public struct ButterflyProgressData
{
	public int ButterflyIndex;

	public float ButterflyTargetDelta;

	public float SingleButterflyTarget;

	public bool TakeDeltaIntoAccount;
}
