using UnityEngine;

[CreateAssetMenu(fileName = "BoosterPlacementHelper", menuName = "ScriptableObjects/Boosters/BoosterPlacementHelper")]
public class BoosterPlacementHelper : ScriptableObject
{
	[SerializeField]
	private BoosterSelectionCalculationObject _boosterSelectionCalculationObject;

	[SerializeField]
	private LevelSystem _levelSystem;

	public int GetSuperWaterCanPlacement()
	{
		return 0;
	}

	public int GetHorizontalShearPlacement()
	{
		return 0;
	}

	public int GetVerticalShearPlacement()
	{
		return 0;
	}

	public int GetRowWindBlowerPlacement()
	{
		return 0;
	}

	public int GetColumnWindBlowerPlacement()
	{
		return 0;
	}

	public int GetTrovelPlacement()
	{
		return 0;
	}

	public int GetSexyPotPlacement()
	{
		return 0;
	}

	public int GetWaterCanPlacement()
	{
		return 0;
	}

	public int GetBombPlacement()
	{
		return 0;
	}

	public int GetSmallFertilizerPlacement()
	{
		return 0;
	}

	public int GetSlotUnlockPlacement()
	{
		return 0;
	}

	public int GetPaintBrushPlacement(int flowerId)
	{
		return 0;
	}

	public int GetWaterCanPlacement(TrayType trayType)
	{
		return 0;
	}

	public int[] GetSwapSlotsPlacement()
	{
		return null;
	}
}
