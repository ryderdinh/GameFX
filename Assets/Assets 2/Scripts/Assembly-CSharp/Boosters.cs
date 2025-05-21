using System.Collections.Generic;
using UnityEngine;

public abstract class Boosters : ScriptableObject
{
	public BoostersTypes Type;

	public MissionType MissionType;

	public string Name;

	[SerializeField]
	protected string Description;

	[SerializeField]
	protected string DetailedDescription;

	public BoosterAffect Affect;

	public BoosterCategory Category;

	public BoosterLevel BoosterLevel;

	public PassiveBoosterCategory PassiveBoosterCategory;

	public PassiveBoosterType PassiveBoosterType;

	public IconType IconType;

	public Sprite Sprite;

	[SerializeField]
	protected GameObject IconPrefab;

	public Sprite BgSprite;

	public SmallIconType SmallIconType;

	public Sprite PredefinedSmallIcon;

	public ResourcesPrefab<BoosterDropObject> BoosterDropObject;

	[SerializeField]
	protected GameObject SmallIconPrefab;

	[SerializeField]
	protected int UnlockingScore;

	[SerializeField]
	private bool _addScore;

	[SerializeField]
	private int _scoreToAdd;

	[SerializeField]
	private float _scorePercentage;

	[SerializeField]
	private bool _addCoins;

	[SerializeField]
	private int _coinsToAdd;

	[SerializeField]
	private ValueRangeInt _rewardValueRange;

	[SerializeField]
	private int _passiveBoostertimeDuration;

	public float BoosterExecutionDelay;

	[Header("Booster View Configs")]
	[SerializeField]
	private Vector3 _iconPositionDelta;

	[SerializeField]
	private Vector2 _descriptionPositionDelta;

	[SerializeField]
	private Vector2 _descriptionRectSizeDelta;

	[SerializeField]
	private Vector2 _namePositionDelta;

	[SerializeField]
	private float _iconScaleFactor;

	[SerializeField]
	private float _nameIconScaleFactor;

	[SerializeField]
	private Vector3 _iconRotationOnView;

	[SerializeField]
	private ResourcesSprite _boosterNameSprite;

	[SerializeField]
	private Vector2 _iconHoverPosition;

	protected int _ItemId;

	private Camera _worldCamera;

	private ProgressionSystem _progression;

	private AllItemsObject _allItemsObject;

	private bool _isUnlocked;

	protected IBoosters IBoosters;

	private BoosterDropObject _boosterDropObject;

	public Vector3 IconPositionDelta => default(Vector3);

	public Vector2 DescriptionPositionDelta => default(Vector2);

	public Vector2 DescriptionRectSizeDelta => default(Vector2);

	public Vector2 NamePositionDelta => default(Vector2);

	public float IconScaleFactor => 0f;

	public float NameIconScaleFactor => 0f;

	public Vector3 IconRotationOnView => default(Vector3);

	public ResourcesSprite BoosterNameSprite => null;

	public Vector3 IconHoverPosition => default(Vector3);

	public int ScoreToAdd => 0;

	public int CoinsToAdd => 0;

	public ValueRangeInt RewardValueRange => null;

	public int PassiveBoosterTimeDuration => 0;

	public int UnlockScore => 0;

	public virtual void SetItemID(int id)
	{
	}

	public virtual Sprite GetSprite(int id = 0)
	{
		return null;
	}

	public virtual Sprite GetBgSprite(int id = 0)
	{
		return null;
	}

	public virtual void Initialize(IBoosters iboosters)
	{
	}

	private void RegisterEvents()
	{
	}

	private void CheckForBoosterUnlock(float highscore)
	{
	}

	public virtual string GetDescription(int flowerId = 0)
	{
		return null;
	}

	public virtual string GetDetailedDescription(int flowerId = 0)
	{
		return null;
	}

	public virtual bool IsUnlocked()
	{
		return false;
	}

	public virtual bool OnBoosterClick(BoosterViewInfo boosterViewInfo)
	{
		return false;
	}

	protected virtual BoosterActivationDataModel GetBoosterActivationDataModel()
	{
		return default(BoosterActivationDataModel);
	}

	public virtual void OnShowBoosterProduction(Vector3 pos)
	{
	}

	public virtual void OnShowBoosterProduction(List<Vector3> pos)
	{
	}

	public virtual void OnShowBoosterProduction(Vector3 pos, List<bool> slots)
	{
	}

	public virtual void OnShowBoosterProduction(List<Slot> slots)
	{
	}

	public virtual void BoosterExecuted()
	{
	}

	public virtual void BoosterExecutionStarted()
	{
	}

	public virtual void BoosterExecutionInPart(Vector3 slotPosition, int mergedItemID, int streakCount, float animationStartDelay)
	{
	}

	public virtual GameObject GetIconPrefab(object data = null)
	{
		return null;
	}

	public virtual GameObject GetSmallIconPrefab(object data = null)
	{
		return null;
	}

	public virtual void OnBoosterClose()
	{
	}

	public virtual void OnBoosterAdClick()
	{
	}

	public virtual void OnFreeBoosterClick()
	{
	}

	public void OnBoosterDropProduction(BoosterDropData dropData, BoosterDropConfig dropConfig = default(BoosterDropConfig))
	{
	}

	private void GiveProgress(Vector3 slotPosition, int mergedItemID, int streakCount, float animationStartDelay)
	{
	}
}
