using TMPro;
using UnityEngine;

public class LifeTimeMissionObjectView : MissionObjectView
{
	[SerializeField]
	private TextMeshProUGUI _milestoneProgressText;

	private LifeTimeMissionObject _missionObject;

	public void Initialize(MissionType missionType, LifeTimeMissionObject missionObject)
	{
	}

	private void RegisterEvents()
	{
	}

	protected override void CollectingReward()
	{
	}

	public override void Show()
	{
	}
}
