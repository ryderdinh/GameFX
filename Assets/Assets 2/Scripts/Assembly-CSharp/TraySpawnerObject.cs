using System.Collections.Generic;
using DB;
using UnityEngine;

[CreateAssetMenu(fileName = "TraySpawnerObject", menuName = "ScriptableObjects/TraySpawner/Object")]
public class TraySpawnerObject : ScriptableObject
{
	[SerializeField]
	private Tray _tray;

	[SerializeField]
	private ArrayArrayInt _traysCurrentState;

	[SerializeField]
	private DBString _dbTraysState;

	[SerializeField]
	private DishSpawnerObject _dishSpawnerObject;

	[SerializeField]
	private TrayTypeCalculationObject _trayTypeCalculationObject;

	[SerializeField]
	private int _maxTraysToSpawn;

	[SerializeField]
	private Bool _isTutorialActive;

	[SerializeField]
	[Header("FTUE")]
	private LevelSystem _levelSystem;

	[SerializeField]
	private DishSpawnerObject[] _dishSpawnerObjectFTUE;

	[SerializeField]
	private TrayTypeCalculationObject[] _trayTypeCalculationObjectFTUE;

	[Header("Favor")]
	[SerializeField]
	private DishSpawnerObject _dishSpawnerObjectForFavor;

	[SerializeField]
	private int _favorSpawnsToGive;

	private int _remainingFavors;

	private readonly List<Tray> _trays;

	private List<TrayDataModel> _traysData;

	private ArrayArrayInt _slotsData;

	private IBoing _boingHandler;

	private ITrayHandler _trayHandler;

	public int MaxTraysToSpawn => 0;

	public void Initialize(IBoing boingHandler, ArrayArrayInt slotsData, ITrayHandler trayHandler)
	{
	}

	public List<Tray> CreateTrays(Transform parent, ITray trayController)
	{
		return null;
	}

	public void ResetTraysData()
	{
	}

	public void ResetTrays()
	{
	}

	public void IncrementFlowerTier(int id)
	{
	}

	public void RemoveTrayData(int id)
	{
	}

	public void RespawnOneTray(int i)
	{
	}

	public void RespawnTrays()
	{
	}

	public void ActivateFavorSpawning()
	{
	}

	public void ActivateFavorSpawning(int favors)
	{
	}

	public void LoadTrays()
	{
	}

	public void EliminateCakeFromTray(int cakeId, int trayId)
	{
	}

	public List<Tray> GetTraysOnUpdatePotTier(Transform parent, ITray trayController)
	{
		return null;
	}

	private void LoadNewTrays()
	{
	}

	private void LoadNewTray(int i)
	{
	}

	private void LoadRegularTrays()
	{
	}

	private void LoadTraysInFavor()
	{
	}

	private void LoadPersistantTrays()
	{
	}

	private void SaveTrayState()
	{
	}

	private int GetRotationOfHorizontalDish(int index, int slicesToSpawn)
	{
		return 0;
	}

	private int GetRotationOfVerticalDish(int index, int slicesToSpawn)
	{
		return 0;
	}
}
