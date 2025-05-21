using MSKit.UIView;

public struct UIViewDataModel
{
	public Views ViewId;

	public object ViewModel;

	public UIViewDataModel(Views viewId, object viewModel = null)
	{
		ViewId = default(Views);
		ViewModel = null;
	}
}
