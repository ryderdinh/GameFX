using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemUpgradeView : MonoBehaviour
{
	[Header("Upgrade Buttons")]
	[SerializeField]
	private Button _upgradeButtonActive;

	[SerializeField]
	private Button _upgradeButtonInactive;

	[SerializeField]
	private TextMeshProUGUI _upgradeActiveCostText;

	[SerializeField]
	private TextMeshProUGUI _upgradeInactiveCostText;

	[SerializeField]
	private GameObject _coinImage;

	[SerializeField]
	private Transform _container;

	[SerializeField]
	[Header("ItemObject")]
	private ItemObject _itemObject;

	[SerializeField]
	private RawImage _flowerRendererImage;

	[SerializeField]
	private Button _itemObjectbutton;

	[Header("Tier")]
	[SerializeField]
	private TextMeshProUGUI _tierText1;

	[SerializeField]
	private ParticleSystem _tierSplashParticles;

	[Header("Score")]
	[SerializeField]
	private TextMeshProUGUI _scoreText;

	[SerializeField]
	private TextMeshProUGUI _scoreText2;

	[SerializeField]
	private ParticleSystem _scoreSplashParticles;

	[SerializeField]
	private Transform _scoreTransform;

	[SerializeField]
	private TextMeshProUGUI _cardsAmountText;

	[SerializeField]
	private Image _fillBarImage;

	[SerializeField]
	private Image _cardImage;

	[SerializeField]
	private GameObject _maxReachedText;

	[SerializeField]
	private GameObject _upgradeableIconPrefab;

	[SerializeField]
	private GameObject _progressBar;

	private float _unlockButtonInitialScale;

	private FlowerType _flowerType;

	private ItemUpgradeObject _itemUpgradeObject;

	private IItemUpgradeView _itemUpgradeView;

	private Vector3 _upgradeActiveCostTextDefaultPos;

	private Sequence _upgradeButtonSequence;

	private bool _isOpenFromMenu;

	public void Initialize(FlowerType flowerType, ItemUpgradeObject itemUpgradeObject, RenderTexture texture, IItemUpgradeView itemUpgradeView, Sprite cardImage)
	{
	}

	private void RegisterEvents()
	{
	}

	public void Show(bool isOpenFromMenu)
	{
	}

	private void WobbleItemObject()
	{
	}

	private void OpenMarket()
	{
	}

	private void UnlockNextFlowerNextTier()
	{
	}

	protected void PlayButtonImpact()
	{
	}

	public void UpdateUpgradeButton(bool canBuy)
	{
	}

	public void ForceUpdateUpgradeButton(bool canBuy)
	{
	}

	public void SetUpView()
	{
	}

	private void UpdateViewOnFlowerUpgrade(int cost, bool canUnlock, bool canBuy, int flowersMerged, int mergesRequireToUnlock, float score, int tier)
	{
	}

	public void MaxTierReached(float score, int tier, bool flowerUpgraded = false)
	{
	}

	private void AnimateMaxTierReached(int tier, float score)
	{
	}

	private void ForceMaxTierReached(int tier, float score)
	{
	}

	private void AnimateScore(float score, int tier)
	{
	}

	private void ShowProgressBar(int flowersMerged, int mergesRequireToUnlock, float delay = 0f)
	{
	}

	private void ShowMaxTierReached()
	{
	}

	private void HideUpgradeButtons()
	{
	}

	private void SetUpgradeableIconState(bool state)
	{
	}

	private void SetTexts(int tier, float score)
	{
	}

	private void SetTierTexts(int tier)
	{
	}

	private void SetScoreTexts(float score)
	{
	}

	private void UpdateCost(int cost)
	{
	}

	private void UpdateProgressBar(int flowersMerged, int mergesRequireToUnlock, float delay)
	{
	}

	public void ResetProgressAndButtonState()
	{
	}

	private void ShowUpgradeButton()
	{
	}

	private void UpdateProgressText(float x)
	{
	}
}
