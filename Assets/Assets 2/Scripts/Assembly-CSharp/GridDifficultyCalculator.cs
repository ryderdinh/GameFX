using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GridDifficultyCalculator", menuName = "ScriptableObjects/Grid/GridDifficultyCalculator")]
public class GridDifficultyCalculator : ScriptableObject
{
	private int _gridDifficulty;

	private Neighbours _neighbors;

	private Dictionary<int, int> _itemsInNeighborsAsPerTray;

	private List<int> _emptySlotsScore;

	public int GridDifficulty => 0;

	public void Initialize(Neighbours neighbours)
	{
	}

	public void CalculateDifficulty(List<Slot> slots, List<Tray> trays)
	{
	}

	private void CalculateDifficultyOfOccupiedSlots(int index, List<Slot> slots)
	{
	}

	private void CalculateDifficultyOfEmptySlot(int index, List<Slot> slots, List<Tray> trays)
	{
	}
}
