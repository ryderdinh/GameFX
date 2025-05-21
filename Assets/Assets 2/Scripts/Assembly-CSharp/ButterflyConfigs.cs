using UnityEngine;

[CreateAssetMenu(fileName = "Butterfly ", menuName = "ScriptableObjects/BoostersProvider/Butterfly")]
public class ButterflyConfigs : BoosterProviderConfigs
{
	public int MaxBoardValue;

	public GameObject ButterflyObject;

	public float TimeToRecheck;

	public float MovementSpeed;

	public float RotationSpeed;

	public int RoamingAroundTime;

	public int ExitingTime;

	public int BlinkingTime;

	public int SittingOnFlowerTime;

	public int Coins;

	public int AnimateCoinsCount;

	public int MinDistanceToSlowMovementSpeed;

	public int MinDistanceToReachToDestination;

	public float ButterflyInitialEmissionValue;

	public float ButterflyWarningStartEmissionValue;

	public float ButterflyWarningEndEmissionValue;

	public float WarningTime;

	[Header("Scaling Configs")]
	public float ButterflyDefaultScale;

	public float ButterflyWarningScale;

	public float WarningScaleDuration;

	public float ButterflySpawningScale;

	[Header("Spawning Configs")]
	public Color ButterflyColor;

	[Header("Unlocking Configs")]
	[Tooltip("Number of Levels Completed")]
	public int ButterflyUnlockLevel;

	public int ButterflyUnlockWorld;

	private ButterflyProgressData _progressData;

	public void SetButterflyProgressData(ButterflyProgressData data)
	{
	}

	public ButterflyProgressData GetButterflyProgressData()
	{
		return default(ButterflyProgressData);
	}
}
