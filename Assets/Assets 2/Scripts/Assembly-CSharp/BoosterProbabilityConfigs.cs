using UnityEngine;

[CreateAssetMenu(fileName = "BoosterProbabilityConfigs", menuName = "ScriptableObjects/Boosters/SpinnerProbabilities/BoosterProbabilities")]
public class BoosterProbabilityConfigs : ScriptableObject
{
	public FlowerUpgradeProbabilityConfigs FlowerUpgradeProbabilityConfigs;

	public FlowerCardsProbabilityConfigs FlowerCardsProbabilityConfigs;

	[Header("----COINS Probabilies Data----")]
	public CoinsProbabilityConfigs CoinsProbabilityConfigs;

	public BoosterProbabilitiesTable BoosterTypePassiveProbabilitiesCoinHeavy;

	public CashObject CashObject;

	[Header("----FTUE Probabilies Data----")]
	public BoostersTypes[] FTUEPredefinedBoosterType;

	public BoosterProbabilityGroup[] FTUEBoosterProbabilityGroup;

	[Header("----Normal GamePlay Probabilities Data----")]
	public BoosterProbabilitiesTable BoosterTypeActiveProbabilities;

	public BoosterProbabilitiesTable BoosterTypePassiveProbabilities;

	public BoosterProbabilitiesTable RespinBoosterTypeActiveProbabilities;

	public BoosterProbabilitiesTable RespinBoosterTypePassiveProbabilities;

	public BoosterProbabilitiesTable AnyBoosterTypeProbabilities;

	public BoosterProbabilitiesTable RespinAnyBoosterTypeProbabilities;

	public BoostersTypes[] PredefinedPassiveBoosterTypes;

	public PredefinedFlowerUpgradeData[] PredefinedFlowerUpgradeBoosterData;
}
