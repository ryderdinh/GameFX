using DB;
using UnityEngine;

[CreateAssetMenu(fileName = "CashObject", menuName = "ScriptableObjects/ProgressionSystem/CashObject")]
public class CashObject : ScriptableObject
{
	[SerializeField]
	private DBInt _dbCash;

	[SerializeField]
	private UserJourneySystem _userJourneySystem;

	private int _cash;

	public int Cash => 0;

	public void Initialize()
	{
	}

	public void AddCash(CoinSource source, int cash)
	{
	}

	public bool DeductCash(CoinSink sink, int cash)
	{
		return false;
	}

	public bool CanBuy(int cost)
	{
		return false;
	}
}
