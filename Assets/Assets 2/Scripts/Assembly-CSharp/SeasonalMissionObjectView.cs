public class SeasonalMissionObjectView : SingleMissionObjectView
{
	private ISingleMissionObjectView _iSingleMissionObjectView;

	private SeasonalMissionController _seasonalMissionController;

	public void Initialize(SeasonalMissionController seasonalMissionController, int id, ISingleMissionObjectView iSingleMissionObjectView)
	{
	}

	public override void CollectingReward()
	{
	}

	protected override void RegisterEvents()
	{
	}
}
