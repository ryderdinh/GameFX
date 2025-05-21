using System;
using DB;
using UnityEngine;

[CreateAssetMenu(fileName = "CardsChestSystem", menuName = "ScriptableObjects/Cards/CardsChestSystem")]
public class CardsChestSystem : ScriptableObject
{
	[SerializeField]
	private CardsChestData _chestData;

	[SerializeField]
	private MatchesSystem _matchesSystem;

	[SerializeField]
	private ItemSystem _itemSystem;

	[SerializeField]
	private DBInt _currentChestIndex;

	[SerializeField]
	private DBBool _chestTutorialShown;

	[SerializeField]
	private TurboModeSystem TurboSystem;

	[SerializeField]
	private PowerUpsSystem PowerUpsSystem;

	private int _chestIndex => 0;

	public bool ChestTutorialShown => false;

	public bool CanShowChestTutorial => false;

	public int CurrentMatches => 0;

	public int RequiredMatches => 0;

	public void ChestGiven()
	{
	}

	public bool CanGiveChest()
	{
		return false;
	}

	public CardsItemData GetCurrentChestRewards()
	{
		return null;
	}

	public void AddCards(CardsItemData data, FlowerCardSource source, Action callback = null, bool canAnimateAfterClaim = true)
	{
	}

	public void AddCards(CardsToAddData cardsToAddData)
	{
	}
}
