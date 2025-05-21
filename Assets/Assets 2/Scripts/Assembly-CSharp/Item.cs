using DB;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/Item", order = 1)]
public class Item : ScriptableObject, IItemUpgradeObject
{
	public int ID;

	public FlowerType FlowerType;

	public MissionType MissionType;

	public FlowerTierData[] Objects;

	public float ProbabilityToGiveCardOnMerge;

	public int UnlockingScore;

	public int FTUEUnlockingScore;

	public ItemState ItemState;

	public Color FlowerParticleColor;

	public Color FlowerColor;

	public Color FlowerTrailColor;

	public string FlowerColorName;

	public string FlowerColorCode;

	public Sprite FlowerCardIconLarge;

	public Sprite FlowerCardIconSmall;

	public Texture FlowerCardTexture;

	public ItemUpgradeObject ItemUpgradeObject;

	[SerializeField]
	private int MultiplierScore;

	[SerializeField]
	private DBInt _dbTierID;

	[SerializeField]
	private ItemUpgradeSystem _itemUpgradeSystem;

	private int _currentTierID;

	private int _previousTierID;

	private int _bonusScore;

	private int _bonusCoins;

	private bool _giveCard;

	public int CurrentTierID => 0;

	public FlowerUIObject CakeUIObjectLevel0 => null;

	public FlowerUIObject CakeUIObject => null;

	public ResourcesMesh MidMesh => null;

	public ResourcesTexture FlowerTexture => null;

	private int CurrentPoolId => 0;

	private int PreviousPoolId => 0;

	public void Initialize()
	{
	}

	public int GetFlowerBonusOnStreak(int streakCount)
	{
		return 0;
	}

	public int GetFlowerBaseScore()
	{
		return 0;
	}

	public Flower GetFlowerObject()
	{
		return null;
	}

	public void ReturnFlowerObject(Flower flower)
	{
	}

	public void ReturnFlowerObjectFromPreviousTier(Flower flower)
	{
	}

	public void DestroyFlowerPoolFromPreviousTier()
	{
	}

	public void UpdatePreviousTierID(int tierID)
	{
	}

	public void CreateFlowerPoolForCurrentTier()
	{
	}

	public bool IncrementFlowerTier()
	{
		return false;
	}

	public bool UpdateFlowerTier(int amount)
	{
		return false;
	}

	public int GetBonusCoins()
	{
		return 0;
	}

	public int GetBonusScore()
	{
		return 0;
	}

	public void IncrementBonusCoins(int coins)
	{
	}

	public void DeductBonusCoins(int coins)
	{
	}

	public void ResetBonusCoins()
	{
	}

	public void IncrementBonusScore(int score)
	{
	}

	public void DeductBonusScore(int score)
	{
	}

	public void ResetBonusScore()
	{
	}

	public void ResetItemTier()
	{
	}

	public bool CanUpdateTier()
	{
		return false;
	}

	private bool UpdateTier(int amount)
	{
		return false;
	}

	private bool UpdateTier()
	{
		return false;
	}

	private void SetDBTierID()
	{
	}

	bool IItemUpgradeObject.CanUpdateTier()
	{
		return false;
	}

	int IItemUpgradeObject.CardsRequiredToUnlockNextTier()
	{
		return 0;
	}

	int IItemUpgradeObject.CostRequiredToUnlockNextTier()
	{
		return 0;
	}

	void IItemUpgradeObject.UpdateTier()
	{
	}

	int IItemUpgradeObject.FlowerId()
	{
		return 0;
	}

	Sprite IItemUpgradeObject.CardSprite()
	{
		return null;
	}

	float IItemUpgradeObject.Score()
	{
		return 0f;
	}

	int IItemUpgradeObject.Tier()
	{
		return 0;
	}

	public bool CanGiveCardOnMerge()
	{
		return false;
	}

	public bool IsCardGivenOnMerge()
	{
		return false;
	}
}
