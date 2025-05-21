using System.Collections.Generic;
using UnityEngine;

public class SortTesting : MonoBehaviour
{
	[SerializeField]
	private SortTestingDataObject _testingData;

	[SerializeField]
	private List<SlotData> _gridState;

	private float _normalizer;

	private SortDirection _neighboursDirection;

	private readonly List<Dictionary<int, SlotData>> _allPossibleStates;

	private readonly List<List<MovementData>> _allMoves;

	private readonly List<float> _scoresList;

	private readonly List<int> _uniqueItemIdsInSlots;
}
