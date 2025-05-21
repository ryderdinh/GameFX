using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class SlotData
{
	public int SlotId;

	[SerializeField]
	public List<int> ItemsInSlot;

	private const int _maxItems = 6;

	public SlotData(int id)
	{
	}

	public SlotData(int id, List<int> items)
	{
	}

	public SlotData(SlotData data)
	{
	}

	public bool HasSpace()
	{
		return false;
	}

	public void AddItem(int item)
	{
	}

	public void RemoveItem(int item)
	{
	}

	public bool ContainsItem(int item)
	{
		return false;
	}

	public void RearrangeSortItems(List<int> items)
	{
	}

	public int UniqueItemsCount()
	{
		return 0;
	}

	public List<int> UniqueItemsList()
	{
		return null;
	}

	public int GetItemCount(int item)
	{
		return 0;
	}

	public int GetSpaceInSlot()
	{
		return 0;
	}

	public bool IsEmptySlot()
	{
		return false;
	}

	public bool IsFullSlot()
	{
		return false;
	}

	public bool HasUniqueItem()
	{
		return false;
	}

	public bool IsCompleted()
	{
		return false;
	}
}
