using UnityEngine;

[CreateAssetMenu(fileName = "FlowerTierUpdate", menuName = "ScriptableObjects/Boosters/FlowerTierUpdate")]
public class FlowerTierUpdate : Boosters
{
	[SerializeField]
	private Sprite[] _sprites;

	private int _flowerID;

	public override bool OnBoosterClick(BoosterViewInfo boosterViewInfo)
	{
		return false;
	}

	public override void OnBoosterClose()
	{
	}

	public override string GetDescription(int reward = 0)
	{
		return null;
	}

	public override void OnShowBoosterProduction(Vector3 pos)
	{
	}

	public override Sprite GetBgSprite(int id)
	{
		return null;
	}
}
