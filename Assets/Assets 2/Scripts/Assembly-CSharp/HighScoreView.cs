using MSKit.UIView;

public class HighScoreView : BaseUIViewController<HighScoreViewRefs>
{
	private int _highestLevel;

	private int _finalLevel;

	private BestRecordModel _bestRecordModel;

	public override void Show(object model = null)
	{
	}

	public override void RegisterEvents()
	{
	}

	public override void UnregisterEvents()
	{
	}

	public override void InitializeTexts()
	{
	}

	public override void InitializeButtons()
	{
	}

	private void UpdateHighScore(int currentLevel, int finalLevel)
	{
	}

	private void UpdateLabel(bool state)
	{
	}

	private void SetHighScoreState(bool state)
	{
	}

	private void SetProgressState(bool state)
	{
	}

	private void SetCompletedState(bool state)
	{
	}
}
