using UnityEngine;

[CreateAssetMenu(fileName = "RowSort", menuName = "ScriptableObjects/Boosters/RowSort")]
public class RowSort : Boosters
{
	[SerializeField]
	private WindBlowerRowViewConfigs _configs;

	private WindBlowerRowProductionObject _productionObject;

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
