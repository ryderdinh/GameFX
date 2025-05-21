using UnityEngine;
using UnityEngine.UI;

public class MainMenuSPPController : MonoBehaviour
{
	[SerializeField]
	private Button _sppButton;

	[SerializeField]
	private RectTransform _sppButtonRect;

	[SerializeField]
	private FlowerSpreadView _flowerSpreadParticles;

	[SerializeField]
	private SPPMainMenuIconView _sppMainMenuIconView;

	[SerializeField]
	private SPPTutorialMask _sppTutorial;

	[SerializeField]
	private SeasonalProgressPassSystem _seasonalProgressPassSystem;

	public Transform IconTransform => null;

	public void InitializeSpp()
	{
	}

	public void Initialize()
	{
	}

	private void RegisterEvents()
	{
	}

	public void Show(MainMenuType mainMenuType)
	{
	}

	private void ShowTutorial(MainMenuType mainMenuType)
	{
	}

	public void Hide()
	{
	}

	public void PlayFlowerParticles(float delay, MainMenuType mainMenuType)
	{
	}

	private void SPPButtonClicked()
	{
	}

	private void PlayButtonImpact()
	{
	}
}
