public struct ProductName
{
	public string Name;

	public Offers OfferType;

	public int ProductIdIndex;

	public ProductName(string name, int index)
	{
		Name = null;
		OfferType = default(Offers);
		ProductIdIndex = 0;
	}
}
