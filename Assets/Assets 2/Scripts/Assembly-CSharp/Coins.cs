using UnityEngine;

[CreateAssetMenu(fileName = "Coins", menuName = "ScriptableObjects/Boosters/Coins")]
public class Coins : Boosters
{
	[SerializeField]
	private Vector3 _startPosition;

	[SerializeField]
	private CashObject _cashObject;

	[SerializeField]
	private Sprite[] _sprites;

	public override void BoosterExecuted()
	{
	}

	public override bool OnBoosterClick(BoosterViewInfo boosterViewInfo)
	{
		return false;
	}

	public override string GetDescription(int coins = 0)
	{
		return null;
	}

	public override Sprite GetSprite(int id)
	{
		return null;
	}
}
