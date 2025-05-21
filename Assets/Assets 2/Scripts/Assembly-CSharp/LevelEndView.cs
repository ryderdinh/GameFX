using MSKit.UIView;

public abstract class LevelEndView<T> : BaseUIViewController<T> where T : LevelEndViewRefs
{
	public override void Show(object model = null)
	{
	}

	public override void InitializeButtons()
	{
	}

	public override void InitializeTexts()
	{
	}

	public override void RegisterEvents()
	{
	}

	public override void UnregisterEvents()
	{
	}

	public virtual void RetryButtonClicked()
	{
	}
}
