using UnityEngine;

[CreateAssetMenu(fileName = "TrayTypeCalculationObject", menuName = "ScriptableObjects/TraySpawner/TrayTypeCalculationObject")]
public class TrayTypeCalculationObject : ScriptableObject
{
	[Header("Double Dish")]
	[SerializeField]
	private float _doubleDishSpawnProb;

	[SerializeField]
	private float _doubleDishSpawnProbOnHighScore;

	[SerializeField]
	private int _scoreThresholdToChangeDishSpawnProb;

	[SerializeField]
	private float _doubleDishProbIncrementalIncrease;

	[SerializeField]
	private float _doubleDishProbIncreaseInHardMode;

	[SerializeField]
	[Header("Hard Mode")]
	private int _maxDoubleDishTrays;

	[SerializeField]
	private int _scoreToActivateDoubleTrays;

	[Header("Score Value")]
	[SerializeField]
	private ScoreSystem _scoreSystem;

	[Header("Slots State")]
	[SerializeField]
	private SlotsStateObject _slotsStateObject;

	[SerializeField]
	private float _probToDecreaseOnLockedSlots;

	private bool _doubleTraySpawnedInLastTurn;

	private float _doubleDishProb;

	private int _doubleTraysSpawned;

	private void OnEnable()
	{
	}

	public void CalculateDoubleDishProb()
	{
	}

	public TrayType GetTrayTypeToSpawn()
	{
		return default(TrayType);
	}
}
