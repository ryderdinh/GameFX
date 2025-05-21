using UnityEngine;

[CreateAssetMenu(fileName = "GridPrePopulationSystem", menuName = "ScriptableObjects/Grid/GridPrePopulationSystem")]
public class GridPrePopulationSystem : ScriptableObject
{
	[SerializeField]
	private GridPrePopulationPresetObject[] _allPresets;

	[SerializeField]
	private GridPrePopulationPresetData[] _prePopulationPresetsData;

	[SerializeField]
	private LevelSystem _levelSystem;

	[SerializeField]
	private MetaSystem _metaSystem;

	[SerializeField]
	private RemoteAppConfig _remoteAppConfig;

	private IGridPrePopulation _gridPrePopulation;

	public bool DebugModeActive;

	public int PrePopulationId;

	public void Initialize(IGridPrePopulation gridPrePopulation)
	{
	}

	public void PrePopulate(bool isLoaded)
	{
	}

	private void DebugPopulate()
	{
	}

	public void ResetPrePopulation()
	{
	}
}
