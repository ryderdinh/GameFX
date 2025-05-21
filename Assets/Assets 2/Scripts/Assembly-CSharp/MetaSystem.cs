using Analytics;
using Core.Server;
using DB;
using UnityEngine;

[CreateAssetMenu(fileName = "MetaSystem", menuName = "ScriptableObjects/Meta/MetaSystem")]
public class MetaSystem : ScriptableObject
{
	public MetaWorldConfig WorldConfigs;

	public ResourcesPrefab<World>[] Shops;

	public ResourcesPrefab<GameObject>[] ConstructionSites;

	[SerializeField]
	private AnalyticsSystem _analyticsSystem;

	[SerializeField]
	private DBInt _dbMetaInProgress;

	[SerializeField]
	private DBInt _dbCurrentWorldId;

	[SerializeField]
	private UserStateBackup _userState;

	private int _metaInProgress;

	private int _currentWorldId;

	public int CurrentWorldInProgressID => 0;

	public int MetaInProgressID => 0;

	public int MetaInProgress => 0;

	public bool AllWorldsUnlocked => false;

	public void Initialize()
	{
	}

	private void RegisterEvents()
	{
	}

	public void IncrementCurrentWorldId()
	{
	}

	public void IncrementMetaInProgressID()
	{
	}

	public string GetMetaShopName(int index)
	{
		return null;
	}

	public void LogWorldCompleteEvent()
	{
	}

	public void LogShopCompleteIndex(int index)
	{
	}
}
