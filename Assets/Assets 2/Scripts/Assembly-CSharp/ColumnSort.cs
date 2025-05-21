using UnityEngine;

[CreateAssetMenu(fileName = "ColumnSort", menuName = "ScriptableObjects/Boosters/ColumnSort")]
public class ColumnSort : Boosters
{
	[SerializeField]
	private WindBlowerColumnViewConfigs _configs;

	private WindBlowerColumnProductionObject _productionObject;

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
