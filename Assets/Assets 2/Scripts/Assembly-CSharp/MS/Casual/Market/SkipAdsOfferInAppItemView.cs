using TMPro;
using UnityEngine;

namespace MS.Casual.Market
{
	public class SkipAdsOfferInAppItemView : SpecialOfferInAppItemView
	{
		[SerializeField]
		private TextMeshProUGUI _cardsAmount;

		protected override void LoadSpecialOfferData(ISpecialOffer iSpecialOffer)
		{
		}
	}
}
