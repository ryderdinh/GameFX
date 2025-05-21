using System.Collections.Generic;
using DB;
using UnityEngine;

[CreateAssetMenu(fileName = "DishSpawnerObject", menuName = "ScriptableObjects/DishSpawner/Object")]
public class DishSpawnerObject : ScriptableObject
{
	[SerializeField]
	private bool _isFTUESpawner;

	[SerializeField]
	private DishUpgradableObject dishes;

	[SerializeField]
	private TurboModeSystem _turboMode;

	[SerializeField]
	private LevelSystem _levelSystem;

	[Header("Cake types in single dish")]
	[SerializeField]
	private List<float> _cakeTypesInSingleDishProb;

	[SerializeField]
	private List<float> _cakeTypesInSingleDishProbInHardMode;

	[Header("Cake Slices")]
	[SerializeField]
	private int _maxSlicesToSpawn;

	[SerializeField]
	private int _maxSlicesToSpawnForDualTray;

	[SerializeField]
	private List<float> _cakeSlicesProb;

	[SerializeField]
	private List<float> _cakeSlicesProbForDualTray;

	[SerializeField]
	private ScoreSystem _scoreSystem;

	[SerializeField]
	private CurrentItemsObject _currentItemsInProgress;

	[SerializeField]
	private ItemSystem _itemSystem;

	[Header("Best Pot Probability")]
	[SerializeField]
	private BestPotProbability _bestPotProbabilityNormal;

	[SerializeField]
	private BestPotProbability _bestPotProbabilityScoreBased;

	[SerializeField]
	private BestPotProbability _bestPotProbabilityHard;

	[SerializeField]
	private GridDifficultyCalculator _gridDifficultyCalculator;

	[SerializeField]
	private ArrayBool _gridLockedState;

	[SerializeField]
	private ArrayInt _tempCakeData;

	[SerializeField]
	private GridConfig _gridConfigs;

	private int _bestPotIndex;

	private int _bestPotSlot;

	private readonly HashSet<int> _cakesAdded;

	private readonly List<int> _cakeSlicesToSpawn;

	private readonly List<int> _cakesTempList;

	public int BestPotSlot => 0;

	public void Initialize()
	{
	}

	public void ResetBestPot()
	{
	}

	public Dish SpawnDishes(Transform dishContainer, ArrayInt data, bool updateCakesData, List<Collider> boingColliders, ArrayArrayInt slotsData = null, TutorialType tutorialType = TutorialType.None, int rotationOffset = -1, bool canSpawnBestDish = false, bool forceGiveBestPot = false, int cakeSlicesToSpawn = -1, bool isDualTray = false)
	{
		return null;
	}

	public Dish PrePopulateDishes(Transform dishContainer, ArrayInt data, List<Collider> boingColliders, GridPrePopulationData prePopulationData)
	{
		return null;
	}

	private float GetBestPotProbability()
	{
		return 0f;
	}

	private int GetTypeOfCakesToSpawn()
	{
		return 0;
	}

	public int GetCakeSlicesToSpawn(bool isDualTray)
	{
		return 0;
	}

	public Dish GetSexytPot(List<Collider> boingColliders, ArrayArrayInt slotsData, int index, ArrayBool lockedState)
	{
		return null;
	}

	private List<int> GetCakesToSpawn(int cakeTypesToSpawn, int cakeSlicesToSpawn, bool forceAll = false)
	{
		return null;
	}

	private List<int> GetPreDefinedCakesToSpawn(GridPrePopulationData prePopulationData)
	{
		return null;
	}

	private List<int> GetTutorialCakes(TutorialType tutorialType)
	{
		return null;
	}

	public List<int> GetBestPossibleDish(ArrayArrayInt slotsData, int index, ArrayBool lockedState, int maxPetalsInPot, int cakeSlicesToSpawn = -1, bool isDualTray = false)
	{
		return null;
	}
}
