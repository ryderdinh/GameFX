using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "AllItemsObject", menuName = "ScriptableObjects/ProgressionSystem/ItemSystem/AllItemsObject")]
public class AllItemsObject : ScriptableObject
{
	[SerializeField]
	private List<Item> _allItems;

	private Dictionary<int, Item> _itemsDict;

	public List<Item> Items => null;

	public Dictionary<int, Item> ItemsDict => null;

	private void OnEnable()
	{
	}

	public FlowerType FlowerIdToType(int id)
	{
		return default(FlowerType);
	}

	public MissionType FlowerIdToMissionType(int id)
	{
		return default(MissionType);
	}

	public void AddCards(CardsToAddData cardsData)
	{
	}
}
