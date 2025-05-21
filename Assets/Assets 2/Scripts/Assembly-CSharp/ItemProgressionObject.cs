using System.Collections.Generic;
using DB;
using UnityEngine;

[CreateAssetMenu(fileName = "ItemProgressionObject", menuName = "ScriptableObjects/ProgressionSystem/ItemProgressionObject")]
public class ItemProgressionObject : ScriptableObject
{
	[SerializeField]
	private DBInt _dbUnlockedItemsCount;

	[SerializeField]
	private Int _currentScore;

	[SerializeField]
	private CurrentItemsObject _currentItemIds;

	[SerializeField]
	private Bool _canShowProgress;

	private int _unlockedItemsCount;

	private int _maxCount;

	private List<Item> _allItems;

	private Queue<Item> _unlockedItems;

	private bool _isNewItemUnlocked;

	public Item NextLockedItem { get; private set; }

	public int LastUnlockedItemScore { get; private set; }

	public int NextItemUnlockScore { get; private set; }

	public int UnlockedItemsCount => 0;

	public CurrentItemsObject GetCurrentItemsObject => null;

	public void Initialize(List<Item> allItems, int maxCount, int initialUnlockAbleItems)
	{
	}

	public int GetLastUnlockedItemID()
	{
		return 0;
	}

	public bool AllItemsUnlocked()
	{
		return false;
	}

	private void LoadCurrentProgression(int initialUnlockAbleItems)
	{
	}

	public void ResetItemProgress()
	{
	}

	public bool UnlockNextItem(int currentScore, bool initialUnlock = false)
	{
		return false;
	}

	private void SaveUnlockedItemsCount()
	{
	}

	public bool CanUnlockNextItem(float currentScore)
	{
		return false;
	}

	private void LoadUnlockedItem()
	{
	}

	private void UpdateNextItemScore(int currentScore = 0)
	{
	}

	private bool UnlockItem(int itemID, bool initialUnlock = false)
	{
		return false;
	}

	private bool AllCakesUnlocked()
	{
		return false;
	}

	public void ShowNextUnlockItemView(int currentScore)
	{
	}
}
