using System.Collections.Generic;
using UnityEngine;

namespace MSKit.UIView
{
	public class UIViewController : BaseUIViewController<UIViewRefs>
	{
		private readonly Dictionary<Views, BaseUIViewController> _bindedUIViews;

		private readonly Dictionary<Views, BaseUIViewController> _activeViews;

		[SerializeField]
		private List<Views> _activeViewIds;

		private UICameraData _uICameraModel;

		private UICanvasGroupData _uICanvasGroupData;

		public override void Initialize()
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

		private int GetOpenViewsCount()
		{
			return 0;
		}

		private UICameraData GetUICamera()
		{
			return default(UICameraData);
		}

		private UICanvasGroupData GetUICanvasGroup()
		{
			return default(UICanvasGroupData);
		}

		private void ShowView(UIViewDataModel dataModel)
		{
		}

		private void BindView(Views viewId)
		{
		}

		private void HideView(Views viewId)
		{
		}

		private void HideView()
		{
		}

		private void HideAllViews()
		{
		}

		private bool IsOnlyViewActive(Views viewId)
		{
			return false;
		}

		private bool IsViewActive(Views viewId)
		{
			return false;
		}

		private bool IsViewOnTop(Views viewId)
		{
			return false;
		}

		private void SetMetaCameraState(bool state)
		{
		}
	}
}
