using MS.Casual.Ads;
using TMPro;
using UnityEngine;

namespace MS.Casual.Market
{
	public class RemoveAdsInAppItemView : BaseMarketItemView
	{
		public TextMeshProUGUI PriceTextDepth;

		[SerializeField]
		private RemoveAdsObject _removeAdsObject;

		[SerializeField]
		private GameObject _simpleOfferGroup;

		[SerializeField]
		private GameObject _saleOfferGroup;

		[SerializeField]
		private TextMeshProUGUI _originalPrice;

		[SerializeField]
		private TextMeshProUGUI _salePrice;

		[SerializeField]
		private GameObject _saleTag;

		private int _intializedID;

		public override void OnItemShown()
		{
		}

		protected override void UpdateData()
		{
		}

		protected override void Initialize()
		{
		}

		protected override void PreInitialize()
		{
		}
	}
}
