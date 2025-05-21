using DB;
using UnityEngine;

[CreateAssetMenu(fileName = "SlotsStateObject", menuName = "Game/SlotsStateObject")]
public class SlotsStateObject : ScriptableObject
{
	public ArrayArrayInt GridState;

	public ArrayBool SlotsLockedState;

	private SlotsStateStruct _slotsStateStruct;

	private void OnEnable()
	{
	}

	public int GetLockedSlotsCount()
	{
		return 0;
	}

	public SlotsStateStruct GetSlotsStateStruct()
	{
		return default(SlotsStateStruct);
	}
}
