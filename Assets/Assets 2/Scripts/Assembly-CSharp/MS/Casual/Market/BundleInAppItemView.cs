using TMPro;
using UnityEngine;

namespace MS.Casual.Market
{
	public class BundleInAppItemView : BaseMarketItemView
	{
		public TextMeshProUGUI SkipItsText;

		public TextMeshProUGUI BrushCutterText;

		public TextMeshProUGUI SprayerText;

		public TextMeshProUGUI WheelsBarrowText;

		public Transform[] AnimationPosition;

		protected override void UpdateData()
		{
		}

		public override Vector3 GetAnimationPosition(int id)
		{
			return default(Vector3);
		}
	}
}
