using System.Collections.Generic;
using DB;
using UnityEngine;

[CreateAssetMenu(fileName = "PassiveBoosterController", menuName = "ScriptableObjects/Boosters/PassiveBoosterController")]
public class PassiveBoostersController : ScriptableObject, IPassiveBooster
{
	[SerializeField]
	private DBString _passiveBoosterData;

	private List<Item> _flowers;

	private List<PassiveBoosterData> _passiveBoostersData;

	private MonoBehaviour _mono;

	private List<PassiveBooster> _activePassiveBoosters;

	public void Initialize(MonoBehaviour mono)
	{
	}

	public void ResetAllBoosters()
	{
	}

	public void HaltPassiveBoosters()
	{
	}

	public void ResumePassiveBoosters()
	{
	}

	public void AddPassiveBooster(int id, Boosters boosters)
	{
	}

	private void AddBooster(List<Item> items, int count, int durationInSeconds, PassiveBoosterCategory passiveBoosterCategory, PassiveBoosterType type)
	{
	}

	private long GetExpiryTime(float durationInSeconds)
	{
		return 0L;
	}

	private void InitializeBoosters()
	{
	}

	private void SavePassiveBoosterState()
	{
	}

	void IPassiveBooster.RemovePassiveBooster(PassiveBooster passiveBooster)
	{
	}

	public List<PassiveBooster> GetPassiveBoosters()
	{
		return null;
	}
}
