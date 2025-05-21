using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "FlowerSpreadParticleConfigs", menuName = "ScriptableObjects/FlowerSpreadParticleConfigs")]
public class FlowerSpreadConfigs : ScriptableObject
{
	public List<Sprite> FlowerResourceSprites;

	public ValueRangeInt FlowersToSpawn;

	public ValueRange FlowerScale;

	public float FlowersMoveBunchAnimationDuration;

	public float FlowerMoveInBetweenDelay;

	public float FlowerBunchSpreadDuration;

	public float FlowerBunchSpreadDistance;

	public float FlowerBunchSpreadDelay;
}
