using DB;
using UnityEngine;

[CreateAssetMenu(fileName = "BoosterProbabilityLevelsConfigs", menuName = "ScriptableObjects/Boosters/SpinnerProbabilities/BoosterProbabilityLevels")]
public class BoosterProbabilityLevelsConfigs : ScriptableObject
{
	public BoosterProbabilityConfigs[] BoosterProbabilityConfigs;

	public GridDataObject GridDataObject;

	public SmartBoosterSelectionObject SmartBoosterSelectionObject;

	public DBInt FTUEProbabilityGroupLevel;

	public DBInt PredefinedPassiveBoosterLevel;

	public DBInt PredefinedFlowerUpgradeBoosterIndex;
}
