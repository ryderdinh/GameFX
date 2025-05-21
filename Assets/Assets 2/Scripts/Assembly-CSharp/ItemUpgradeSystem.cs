using System.Collections.Generic;
using DB;
using UnityEngine;

[CreateAssetMenu(fileName = "FlowerUpgradesSystem", menuName = "ScriptableObjects/Item/FlowerUpgradesSystem", order = 1)]
public class ItemUpgradeSystem : ScriptableObject
{
	[SerializeField]
	private DBBool _flowerUpgradeTutorialShown;

	[SerializeField]
	private DBBool _flowerUpgradeMenuTutorialShown;

	private bool _isTutorialCompleted;

	private bool _isMenuTutorialShown;

	private Dictionary<FlowerType, ItemUpgradeObject> _flowerUpgradesDictionary;

	public Dictionary<FlowerType, ItemUpgradeObject> FlowerUpgradesDictionary => null;

	public bool IsTutorialCompleted => false;

	public void Initialize(AllItemsObject allItemsObject)
	{
	}

	public void AddCard(CardsToAddData cardsToAdd)
	{
	}

	public int GetCards(FlowerType flowerType)
	{
		return 0;
	}

	public int GetUpgradeableFlowersCount()
	{
		return 0;
	}

	public bool CanShowFlowerMenuTutorial()
	{
		return false;
	}

	public void FlowerMenuTutorialCompleted()
	{
	}

	public bool CanShowUpgradeTutorial()
	{
		return false;
	}

	public void UpgradeTutorialCompleted()
	{
	}

	public int TotalNumberOfCardsInInventory()
	{
		return 0;
	}
}
