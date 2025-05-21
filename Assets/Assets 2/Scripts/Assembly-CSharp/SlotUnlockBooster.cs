using UnityEngine;

[CreateAssetMenu(fileName = "SlotUnlockBooster", menuName = "ScriptableObjects/Boosters/SlotUnlockBooster")]
public class SlotUnlockBooster : Boosters
{
	[SerializeField]
	private SlotUnlockBoosterViewConfigs _configs;

	private SlotUnlockBoosterProductionObject _productionObject;

	public override bool OnBoosterClick(BoosterViewInfo boosterViewInfo)
	{
		return false;
	}

	public override void OnBoosterClose()
	{
	}

	public override void BoosterExecuted()
	{
	}

	public override void OnShowBoosterProduction(Vector3 pos)
	{
	}
}
