using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CurrentItemsObject", menuName = "ScriptableObjects/ProgressionSystem/ItemProgression/CurrentItemsObject")]
public class CurrentItemsObject : ScriptableObject
{
	[SerializeField]
	private List<int> _currentItemsInProgress;

	private List<int> _allItemsList;

	public List<int> ItemsInProgress => null;

	public List<int> AllItems => null;

	public void Initialize()
	{
	}

	public void Add(int id)
	{
	}

	public void Remove(int id)
	{
	}
}
