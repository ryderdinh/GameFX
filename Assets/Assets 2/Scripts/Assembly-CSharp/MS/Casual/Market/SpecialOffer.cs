namespace MS.Casual.Market
{
	public struct SpecialOffer
	{
		private SpecialOfferType _specialOfferType;

		private string _offerType;

		public SpecialOffer(string offer, SpecialOfferType type)
		{
			_specialOfferType = default(SpecialOfferType);
			_offerType = null;
		}

		public bool IsSpecialOfferPurchased()
		{
			return false;
		}

		public void SpecialOfferPurchased()
		{
		}
	}
}
