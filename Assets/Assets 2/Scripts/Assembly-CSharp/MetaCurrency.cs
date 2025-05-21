using DB;
using UnityEngine;

[CreateAssetMenu(fileName = "MetaCurrency", menuName = "ScriptableObjects/Meta/MetaCurrency")]
public class MetaCurrency : ScriptableObject
{
	[SerializeField]
	private DBFloat _dbCurrency;

	private float _currency;

	public float Currency => 0f;

	public void Initialize()
	{
	}

	public void AddCurrency(float currency)
	{
	}

	public bool DeductCurrency(float currency)
	{
		return false;
	}

	public bool CanUpdateUpgradeable(float score)
	{
		return false;
	}
}
