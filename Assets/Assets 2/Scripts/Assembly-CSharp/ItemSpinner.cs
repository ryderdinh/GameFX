using System.Collections.Generic;
using DB;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemSpinner : MonoBehaviour
{
	[SerializeField]
	private bool _isButterflySpinner;

	[SerializeField]
	private Transform[] _spinnerItemContainer;

	[SerializeField]
	private Image[] _items;

	[SerializeField]
	private RectTransform[] _itemsRect;

	[SerializeField]
	private Image[] _smallIcons;

	[SerializeField]
	private RectTransform[] _smallIconsRect;

	[SerializeField]
	private RectTransform[] _itemsShadow;

	[SerializeField]
	private TextMeshProUGUI[] _itemValue;

	[SerializeField]
	private GameObject[] _itemValueContainer;

	[SerializeField]
	private Image[] _itemsBg;

	[SerializeField]
	private GameObject _cardsValueContainer;

	[SerializeField]
	private TextMeshProUGUI _cardsValueFrontText;

	[SerializeField]
	private TextMeshProUGUI _cardsValueBgText;

	[SerializeField]
	public RectTransform _container;

	[SerializeField]
	private RectTransform _innerContainer;

	[SerializeField]
	private Button _spinnerClickButton;

	[SerializeField]
	public TextMeshProUGUI _description;

	[SerializeField]
	public RectTransform _descriptionRect;

	[SerializeField]
	private UserJourneySystem _userJourneySystem;

	[SerializeField]
	private BoosterSelectionGroup _boosterSelectionGroup;

	[SerializeField]
	private DBString _appliedBoostersData;

	private List<BoostersTypes> _appliedBoostersList;

	private bool _isSpinning;

	private float _moveBackValue;

	private float _height;

	private int _currentIndex;

	private int _selectedIndex;

	private int _currentItemIndex;

	private IBoosterSpinner _boosterSpinnerSelectionHandler;

	private SmartBoosterSelectionObject _smartBoosterSelectionObject;

	private float _spinnerLerpSpeed;

	private PowerUpsSpinnerConfigs _configs;

	private List<Boosters> _allBoosters;

	private ApplyBoosterData _applyBoosterData;

	private bool _isRespinning;

	private BoosterProbabilityGenerator _boosterProbabilityGenerator;

	private GameObject spawnedIconsGameObject;

	private GameObject spawnedSmallIconsGameObject;

	private bool _isPlayLoopSound;

	private bool isStoppingImmediately;

	protected virtual void RegisterEvents()
	{
	}

	public void Initialize(int spinnerId, IBoosterSpinner boosterSpinnerSelectionHandler, PowerUpsSpinnerConfigs configs, BoosterProbabilityLevelsConfigs boosterProbabilityLevelsConfigs)
	{
	}

	private void PrintLogs()
	{
	}

	private void SetSpinnerButtonState(bool state)
	{
	}

	public void StartSpining(bool isRespinning = false, bool isPlayLoopSound = false)
	{
	}

	public virtual void UpdateState()
	{
	}

	public void Update()
	{
	}

	private Sprite GetSelectedBoosterSprite(Boosters boosterConfig)
	{
		return null;
	}

	private void SetSmallIcon(int index)
	{
	}

	private void SetItemValue(int index)
	{
	}

	private void SetDefaultPosition()
	{
	}

	private int CalculateBoosterProbabilityFromRange(List<BoostersTypes> ignorBoosterTypes)
	{
		return 0;
	}

	private void StopAnimation()
	{
	}

	private void SetIconPrefab()
	{
	}

	private void SetSmallIconPrefab()
	{
	}

	public BoostersTypes StopSpining(List<BoostersTypes> ignorBoosterTypes)
	{
		return default(BoostersTypes);
	}

	private void SpinningStopped()
	{
	}

	private void UpdateCardsValueText(int count)
	{
	}

	protected void HideSpinnersOnSelection()
	{
	}

	protected virtual void AdShown(bool result)
	{
	}

	private void SpinnerClicked()
	{
	}

	protected void PlayButtonImpact()
	{
	}

	public void ApplyBooster()
	{
	}

	public void SetIconSize(Vector2 size)
	{
	}

	public void SetDescriptionFontSize(float size)
	{
	}

	public void SetDescriptionSize(Vector2 size)
	{
	}

	public BoostersTypes StopSpinningImmediately(List<BoostersTypes> ignorBoosterTypes)
	{
		return default(BoostersTypes);
	}

	public virtual void SetRvIconState(bool state)
	{
	}

	public void Reset()
	{
	}
}
