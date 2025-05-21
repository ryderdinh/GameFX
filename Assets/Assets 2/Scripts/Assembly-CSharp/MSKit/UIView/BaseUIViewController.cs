using UnityEngine;

namespace MSKit.UIView
{
	public abstract class BaseUIViewController : MonoBehaviour
	{
		public abstract void Show(object model = null);

		public abstract void Hide();
	}
	public abstract class BaseUIViewController<T> : BaseUIViewController where T : BaseUIViewRefs
	{
		[SerializeField]
		protected T _ViewRefs;

		protected bool _isInitialized;

		public abstract void RegisterEvents();

		public abstract void UnregisterEvents();

		public abstract void InitializeTexts();

		public abstract void InitializeButtons();

		public override void Show(object model = null)
		{
		}

		public virtual void Initialize()
		{
		}

		public override void Hide()
		{
		}

		protected void SetState(bool state)
		{
		}

		protected void PlayButtonImpact()
		{
		}
	}
}
