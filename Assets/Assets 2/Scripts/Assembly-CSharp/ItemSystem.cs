using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ItemSystem", menuName = "ScriptableObjects/ItemSystem")]
public class ItemSystem : ScriptableObject
{
	[SerializeField]
	private float _delayToShowNextUnlock;

	[SerializeField]
	private int _initialUnlockAbleItems;

	[SerializeField]
	private int _maxUnlockItemsCount;

	[SerializeField]
	private ItemProgressionObject _itemProgression;

	[SerializeField]
	private AllItemsObject _allItemsObject;

	[SerializeField]
	private ItemUpgradeSystem _itemUpgradeSystem;

	private Dictionary<int, Item> _allItems;

	public int InitialUnlockAbleItems => 0;

	public int MaxUnlockItemsCount => 0;

	public void Initialize()
	{
	}

	private void InitializeItems()
	{
	}

	public int GetNextItemUnlockScore()
	{
		return 0;
	}

	public int GetLastItemUnlockScore()
	{
		return 0;
	}

	public bool MatchMade(FlowerType flowerType, int score)
	{
		return false;
	}

	public bool UnlockNextItem(int score)
	{
		return false;
	}

	public NextLockedItemDataModel LoadCurrentProgress()
	{
		return default(NextLockedItemDataModel);
	}

	public void ResetItemProgress()
	{
	}

	public void UpdatePreviousTierIDAgainstItemID(int id, int tierID)
	{
	}

	public Item GetItemAgainstID(int id)
	{
		return null;
	}

	public Item GetItemAgainstFlowerType(FlowerType flowerType)
	{
		return null;
	}

	public int GetLastUnlockedItemID()
	{
		return 0;
	}

	public int GetAvailableItemsBasedOnScore(float score, bool isFTUE, bool forceAll)
	{
		return 0;
	}

	public void AddBonusScoreToItem(int scoreToAdd, int itemId = 0)
	{
	}

	public void ResetAllItemBonusScore()
	{
	}

	public List<Item> GetAllItems()
	{
		return null;
	}

	public bool IncrementTierAgainstID(int id)
	{
		return false;
	}

	public void AddCards(CardsToAddData cards)
	{
	}

	public int GetTierAgainstItemID(int id)
	{
		return 0;
	}

	public int GetCardsAgainstItemID(FlowerType flowerType)
	{
		return 0;
	}

	public void DestroyFlowerPoolAgainstIDFromPreviousTiers(int id)
	{
	}

	public void CreateFlowerPoolForCurrentTier(int id)
	{
	}

	public Flower GetFlowerObjectAgainstID(int id)
	{
		return null;
	}

	public void ReturnFlowerObject(Flower flower)
	{
	}

	public void ReturnFlowerObjectFromPreviousTier(Flower flower)
	{
	}

	public void ShowNextUnlockItemView(int score)
	{
	}
}
