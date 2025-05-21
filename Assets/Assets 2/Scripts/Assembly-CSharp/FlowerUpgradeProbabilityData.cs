using System;

[Serializable]
public struct FlowerUpgradeProbabilityData
{
	public FlowerType FlowerType;

	public int Probability;

	public int FlowerId => 0;
}
