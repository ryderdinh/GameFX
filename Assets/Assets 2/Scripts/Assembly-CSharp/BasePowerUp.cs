using DB;
using UnityEngine;

public abstract class BasePowerUp : ScriptableObject
{
	[SerializeField]
	private BoostersTypes _type;

	[SerializeField]
	private Boosters _booster;

	[SerializeField]
	private int _cost;

	[SerializeField]
	private DBInt _inventory;

	[SerializeField]
	private DBBool _isEquippedDb;

	[SerializeField]
	private CashObject _cashObject;

	[SerializeField]
	private TraySpawnerObject _traySpawnerObject;

	private int _count;

	private bool _isEquipped;

	public BoostersTypes Type => default(BoostersTypes);

	public int Cost => 0;

	public int Count => 0;

	public bool IsInInventory => false;

	public bool IsEquipped => false;

	public void Initialize()
	{
	}

	public void AddInInventory(int amount)
	{
	}

	public bool Equip()
	{
		return false;
	}

	public bool Use()
	{
		return false;
	}

	public void Reset()
	{
	}

	private bool UseFromInventory()
	{
		return false;
	}

	public bool BuyFromCoins()
	{
		return false;
	}

	private bool CanBuy()
	{
		return false;
	}

	private void UpdateInventory(int amount)
	{
	}
}
