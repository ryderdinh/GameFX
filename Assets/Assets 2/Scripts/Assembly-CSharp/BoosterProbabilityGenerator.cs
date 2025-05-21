using System.Collections.Generic;

public class BoosterProbabilityGenerator
{
	private BoosterProbabilityLevelsConfigs _boosterProbabilityLevelsConfigs;

	private BoosterProbabilityConfigs _boosterProbabilityConfigs;

	private ProbabilityResponse _probabilityResponse;

	private List<BoostersTypes> _ignoreBoosterTypes;

	private Dictionary<int, int> _petaCountOnGrid;

	private bool _isFTUE;

	private int _FTUELevel;

	public void Initialize(BoosterProbabilityLevelsConfigs boosterProbabilityLevelsConfigs)
	{
	}

	public ProbabilityResponse GetBoosterType(int spinnerId, int levelNo, bool isRespin = false, List<BoostersTypes> ignoreBoosterTypes = null, bool isFTUE = false, BoosterSelectionGroup boosterSelectionGroup = BoosterSelectionGroup.Any, bool isBestBooster = false, bool isIncrementFTUELevel = false)
	{
		return default(ProbabilityResponse);
	}

	private ProbabilityResponse GetNewProbabilitiesBooster(BoosterSelectionGroup boosterSelectionGroup, bool isRespin, bool isBestBooster)
	{
		return default(ProbabilityResponse);
	}

	private BoostersTypes CalculateBoosterTypeProbabilities(BoosterTypeProbabilityData[] boosterTypeProbabilitiesData)
	{
		return default(BoostersTypes);
	}

	private void CheckFTUE(bool isIncrementFTUELevel)
	{
	}

	private BoostersTypes GetIfPredefinedPassiveBoosterAvailable()
	{
		return default(BoostersTypes);
	}

	private void PrintIgnoreList()
	{
	}

	private ProbabilityResponse GetProbabilityResponseDataBasedOnBoosterType(BoostersTypes boostersTypes)
	{
		return default(ProbabilityResponse);
	}

	private bool IsPredefinedFlowerUpgradeDataAvailable()
	{
		return false;
	}

	private PredefinedFlowerUpgradeData GetPredefinedFlowerUpgradeData()
	{
		return default(PredefinedFlowerUpgradeData);
	}

	public void PredefinedFlowerUpgradeSelected()
	{
	}

	private FlowerUpgradeProbabilityData CalculateFlowerUpgradeProbability()
	{
		return default(FlowerUpgradeProbabilityData);
	}

	private FlowerUpgradeProbabilityData CalculateFlowerAffectProbability()
	{
		return default(FlowerUpgradeProbabilityData);
	}

	private CoinProbabilityData CalculateCoinsProbability()
	{
		return default(CoinProbabilityData);
	}

	private FlowerCardsProbabilityData CalculateFlowerCardsProbability()
	{
		return default(FlowerCardsProbabilityData);
	}

	private FlowerUpgradeProbabilityData[] GetFilteredFlowers(FlowerUpgradeProbabilityData[] FlowerUpgradeProbabilityData)
	{
		return null;
	}

	private BoostersTypes GetFTUEBooster()
	{
		return default(BoostersTypes);
	}

	public void PrintLogs(List<BoostersTypes> boostersTypes)
	{
	}
}
