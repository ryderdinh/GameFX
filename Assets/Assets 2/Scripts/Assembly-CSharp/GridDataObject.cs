using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GridDataObject", menuName = "Game/GridDataObject")]
public class GridDataObject : ScriptableObject
{
	[SerializeField]
	private SlotsStateObject _slotsStateObject;

	private Dictionary<int, int> _petalsCountDict;

	private void OnEnable()
	{
	}

	public Dictionary<int, int> GetPetalsCountOnGrid()
	{
		return null;
	}

	public int GetFlowerWithMostPetalsOnGrid()
	{
		return 0;
	}
}
