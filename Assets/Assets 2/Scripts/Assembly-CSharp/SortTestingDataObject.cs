using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SortTestingData", menuName = "ScriptableObjects/SortTesting/Object")]
public class SortTestingDataObject : ScriptableObject
{
	public int Rows;

	public int Columns;

	public SlotData SlotToPlace;

	public List<SlotData> GridState;

	public List<SlotData> Result;
}
