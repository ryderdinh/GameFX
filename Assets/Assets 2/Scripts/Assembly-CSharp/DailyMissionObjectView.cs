public class DailyMissionObjectView : SingleMissionObjectView
{
	private ISingleMissionObjectView _iSingleMissionObjectView;

	private DailyMissionController _dailyMissionController;

	public void Initialize(DailyMissionController dailyMissionController, int id, ISingleMissionObjectView iSingleMissionObjectView)
	{
	}

	public override void CollectingReward()
	{
	}

	protected override void RegisterEvents()
	{
	}
}
