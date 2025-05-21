using UnityEngine;
using UnityEngine.UI;

namespace MS.Casual.PieceSort
{
	public class NormalAppreciationBannerView : AppreciationBannerView
	{
		[SerializeField]
		private Image _appreciationImage;

		private GetAppreciationBannerEventData _bannerEventData;

		public override void Initialize()
		{
		}

		private GetAppreciationBannerEventData GetAppreciationBannerView()
		{
			return default(GetAppreciationBannerEventData);
		}

		protected override void RegisterEvents()
		{
		}

		protected override void UnRegisterEvents()
		{
		}

		public override void PlayAppreciationAnimation(CollectablesData data)
		{
		}
	}
}
