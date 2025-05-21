using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace MS.Casual.Market
{
	public abstract class BaseInAppItemView : MonoBehaviour
	{
		[Header("View")]
		public Button BuyButton;

		public TextMeshProUGUI PriceText;

		public virtual void OnItemShown()
		{
		}

		protected abstract void PreInitialize();

		protected abstract void Initialize();

		protected virtual void BuyItem()
		{
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		protected void PlayButtonImpact()
		{
		}

		public virtual Vector3 GetAnimationPosition(int id)
		{
			return default(Vector3);
		}
	}
}
