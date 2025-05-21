using UnityEngine;

[CreateAssetMenu(fileName = "GridPrePopulationFlowerCompPresetObject", menuName = "ScriptableObjects/Grid/GridPrePopulationFlowerCompPresetObject")]
public class GridPrePopulationFlowerCompPresetObject : ScriptableObject
{
	public bool SpawnInLoop;

	public PrePopulatedFlowerData[] FlowerData;
}
