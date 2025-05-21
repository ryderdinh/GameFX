using Analytics;
using DB;
using UnityEngine;

[CreateAssetMenu(fileName = "ItemUpgradeObject", menuName = "ScriptableObjects/Item/ItemUpgradeObject", order = 1)]
public class ItemUpgradeObject : ScriptableObject
{
	[SerializeField]
	private DBInt _cards;

	[SerializeField]
	private FlowerType _flowerType;

	[SerializeField]
	private MissionType _flowerUpgradeMissionType;

	[SerializeField]
	private MissionType _collectCardsMissionType;

	[SerializeField]
	private UserJourneySystem _userJourneySystem;

	[SerializeField]
	private AnalyticsSystem _analyticsSystem;

	private int _cardsCount;

	private CashObject _cashObject;

	private IItemUpgradeObject _itemUpgradeObject;

	public FlowerType FlowerType => default(FlowerType);

	public int Cards => 0;

	public int CardsRequiredToUnlock => 0;

	public int Cost => 0;

	public Sprite CardSprite => null;

	public float Score => 0f;

	public int Tier => 0;

	public void Initialize(IItemUpgradeObject itemUpgradeObject)
	{
	}

	public void AddCard(FlowerCardSource cardSource, int cardsToAdd)
	{
	}

	public bool IsUpgradeAvailable()
	{
		return false;
	}

	public bool CanBuyUpgrade()
	{
		return false;
	}

	public void UpdateFlowerTier()
	{
	}

	public bool CanUpdateTier()
	{
		return false;
	}
}
