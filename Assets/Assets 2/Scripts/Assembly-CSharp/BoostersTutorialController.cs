using System.Collections.Generic;
using DB;
using UnityEngine;

[CreateAssetMenu(fileName = "ToolsTutorialController", menuName = "ScriptableObjects/Tutorial/ToolsTutorialController")]
public class BoostersTutorialController : ScriptableObject
{
	[SerializeField]
	private int _boosterTutorialFTUEStartDelay;

	[SerializeField]
	private int _boosterTutorialStartDelay;

	[SerializeField]
	private Bool _isBoostersTutorialActive;

	[SerializeField]
	private DBString _dbBoostersTutorialShownState;

	[SerializeField]
	private BoosterPlacementHelper _boosterPlacement;

	[SerializeField]
	private bool _forceApplyTutorial;

	private BoostersTutorialState _state;

	private BoostersTypes _type;

	private int _flowerID;

	private bool _canShowBoostersTutorial;

	private Dictionary<BoostersTypes, bool> _boostersTutorialShownState;

	private TutorialController _tutorialController;

	private IBoostersTutorial _boostersTutorial;

	private float _timeRemaining;

	public void Initialize(IBoostersTutorial boostersTutorial)
	{
	}

	private void SetBoostersTutorialShownState()
	{
	}

	private void GetBoostersTutorialShownState()
	{
	}

	private void InitializeEvents()
	{
	}

	public void UpdateBoostersTutorial(float deltaTime)
	{
	}

	private BoostersTutorialDataModel GetBoosterTutorialDataModel()
	{
		return default(BoostersTutorialDataModel);
	}

	private void ShowTutorial(BoostersTutorialDataModel data)
	{
	}

	private void UpdateToolsTutorialState(BoosterActivationDataModel dataModel)
	{
	}

	private void BoosterActivated(BoostersTypes boostersTypes)
	{
	}

	public BoostersTutorialDataModel GetWaterCanBoosterTutorialDataModel(TrayType trayType)
	{
		return default(BoostersTutorialDataModel);
	}
}
