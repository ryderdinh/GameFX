using DB;
using UnityEngine;

[CreateAssetMenu(fileName = "ReviveSystem", menuName = "ScriptableObjects/ReviveSystem")]
public class ReviveSystem : ScriptableObject
{
	[SerializeField]
	[Header("Revive On Ad")]
	private DBInt _revivesUsedDB;

	[SerializeField]
	private DBBool _freeReviveAvailed;

	[SerializeField]
	private RemoteAppConfig _remoteConfigs;

	[Header("Revive On Coins")]
	[SerializeField]
	private int[] _cost;

	[SerializeField]
	private DBInt _reviveOnCoinsCountDB;

	[SerializeField]
	private CashObject _cashObject;

	private int _adRevivesUsed;

	private int _coinRevivesUsed;

	public bool IsFreeReviveAvailed => false;

	public void Initialize()
	{
	}

	public bool CanShowReviveScreen()
	{
		return false;
	}

	public bool IsAdReviveAvailable()
	{
		return false;
	}

	public int GetRemainingAdRevives()
	{
		return 0;
	}

	public void AdReviveUsed()
	{
	}

	public void FreeReviveUsed()
	{
	}

	public int GetCost()
	{
		return 0;
	}

	public bool PurchaseRevive()
	{
		return false;
	}

	public void Reset()
	{
	}
}
