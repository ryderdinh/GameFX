using UnityEngine;

[CreateAssetMenu(fileName = "GridPopulationSystem", menuName = "ScriptableObjects/Grid/GridPopulationSystem")]
public class GridPopulationSystem : ScriptableObject
{
	[SerializeField]
	private GridPrePopulationSystem _prePopulationSystem;

	public void Initialize(IGridPrePopulation gridPrePopulation)
	{
	}

	public void PrePopulate(bool isLoaded)
	{
	}

	public void ResetPrePopulation()
	{
	}
}
