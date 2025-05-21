using MSKit.UIView;
using UnityEngine;
using UnityEngine.Events;

public abstract class BaseUISubViewController<T> : BaseUIViewController<T> where T : BaseUIViewRefs
{
	[HideInInspector]
	public UnityEvent OnCloseView;

	public override void Hide()
	{
	}

	public override void InitializeTexts()
	{
	}

	public override void InitializeButtons()
	{
	}
}
