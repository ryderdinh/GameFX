using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "BoosterController", menuName = "ScriptableObjects/Boosters/BoosterController")]
public class BoostersController : ScriptableObject
{
	[SerializeField]
	private List<Boosters> _boostersList;

	[SerializeField]
	private List<Boosters> _activeBoostersList;

	private Dictionary<BoostersTypes, Boosters> _boosters;

	public Dictionary<BoostersTypes, Boosters> Boosters => null;

	public void Initialize(IBoosters iBooster)
	{
	}

	public void ShowBoosterProduction(BoostersTypes type, List<Vector3> positions)
	{
	}

	public void ShowBoosterProduction(BoostersTypes type, Vector3 positions, List<bool> slots)
	{
	}

	public void ShowBoosterProduction(BoostersTypes type, Vector3 pos)
	{
	}

	public void ShowBoosterProduction(BoostersTypes type, List<Slot> slots)
	{
	}

	public int BoosterUnlockScore(BoostersTypes type)
	{
		return 0;
	}

	public bool IsBoosterUnlocked(BoostersTypes type)
	{
		return false;
	}

	public Boosters GetBooster(BoostersTypes type)
	{
		return null;
	}

	public BoosterAffect GetBoosterAffect(BoostersTypes type)
	{
		return default(BoosterAffect);
	}

	public List<Boosters> GetAllBoosters()
	{
		return null;
	}

	private void ResetAllViews()
	{
	}

	public void BoosterExecuted(BoostersTypes type)
	{
	}

	public void BoosterExecutionStarted(BoostersTypes type)
	{
	}

	public void BoosterExecutionInParts(BoostersTypes type, Vector3 slotPosition, int mergedItemID, int streakCount, float animationStartDelay = 1.75f)
	{
	}

	public void OnBoosterAdClicked(BoostersTypes type)
	{
	}

	public void OnFreeBoosterClicked(BoostersTypes type)
	{
	}

	public bool OnBoosterClick(BoostersTypes type)
	{
		return false;
	}

	public void OnBoosterClose(BoostersTypes type)
	{
	}
}
