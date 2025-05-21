using TMPro;
using UnityEngine;

namespace MS.Casual.Market
{
	public class CardsOfferInAppItemView : SpecialOfferInAppItemView
	{
		[SerializeField]
		private TextMeshProUGUI _cardsAmount;

		protected override void LoadSpecialOfferData(ISpecialOffer iSpecialOffer)
		{
		}
	}
}
