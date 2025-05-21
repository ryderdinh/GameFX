using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SeasonalStageObjectView : MonoBehaviour
{
	[SerializeField]
	private TextMeshProUGUI _stageNumber;

	[SerializeField]
	private Transform _missionObjectViewContainer;

	private SeasonalMissionStage _seasonalMissionStage;

	private List<SeasonalMissionObjectView> _missionObjectViews;

	public void Initialize(SeasonalMissionStage stage, SeasonalMissionObjectView seasonalMissionObjectView)
	{
	}

	public void Show(float delay)
	{
	}

	private void SetupView(float delay)
	{
	}
}
