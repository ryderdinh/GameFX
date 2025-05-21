using MS.Casual.Market;

public interface ISpecialOffer
{
	SpecialOfferTimeController Timer { get; }

	SpecialOfferItemData OfferItemData { get; }

	void PurchaseOffer();
}
