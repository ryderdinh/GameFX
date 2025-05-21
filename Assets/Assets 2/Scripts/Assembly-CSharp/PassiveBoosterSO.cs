using UnityEngine;

[CreateAssetMenu(fileName = "PassiveBooster", menuName = "ScriptableObjects/Boosters/PassiveBooster")]
public class PassiveBoosterSO : Boosters
{
	public override void OnShowBoosterProduction(Vector3 pos)
	{
	}

	public override string GetDescription(int flowerId = 0)
	{
		return null;
	}
}
