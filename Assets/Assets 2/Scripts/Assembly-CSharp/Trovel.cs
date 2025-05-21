using UnityEngine;

[CreateAssetMenu(fileName = "Trovel", menuName = "ScriptableObjects/Boosters/Trovel")]
public class Trovel : Boosters
{
	private TrovelProductionObject _trovelProductionObject;

	[SerializeField]
	private TrovelViewConfig _configs;

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
