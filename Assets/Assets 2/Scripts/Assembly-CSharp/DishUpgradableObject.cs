using DB;
using UnityEngine;

[CreateAssetMenu(fileName = "DishUpgradableObject", menuName = "ScriptableObjects/DishUpgradable/Object")]
public class DishUpgradableObject : ScriptableObject
{
	[SerializeField]
	private Dish _dish;

	[SerializeField]
	private DishTierObject[] _dishesTier;

	[SerializeField]
	private DBInt _dbDishTierID;

	private int _dishTierID;

	public int DishTierID => 0;

	public void Initialize()
	{
	}

	public int GetDishScore()
	{
		return 0;
	}

	public int GetDishScore(int dishTierId)
	{
		return 0;
	}

	public string GetDishName()
	{
		return null;
	}

	public string GetDishName(int dishTierId)
	{
		return null;
	}

	public Dish GetDishObject()
	{
		return null;
	}

	public void ReturnDishObject(Dish pot)
	{
	}

	public bool IncrementDishTier()
	{
		return false;
	}

	public bool UpdateDishTierByAmount(int amount)
	{
		return false;
	}

	public void ResetDishTier()
	{
	}

	public bool CanUpdateDishTier()
	{
		return false;
	}

	public int GetDishTierId()
	{
		return 0;
	}

	public Mesh GetDishMesh()
	{
		return null;
	}

	public Mesh GetDualDishMesh()
	{
		return null;
	}

	public Sprite GetDishNextUpgradeIcon()
	{
		return null;
	}

	private bool UpdateDishTier(int amount)
	{
		return false;
	}

	private bool UpdateDishTier()
	{
		return false;
	}

	private void SetDBDishTierID()
	{
	}
}
