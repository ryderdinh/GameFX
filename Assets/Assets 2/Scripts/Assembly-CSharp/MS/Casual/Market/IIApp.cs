namespace MS.Casual.Market
{
	public interface IIApp
	{
		void PurchaseSuccessfull(bool isRestore);

		void PurchaseFailed();
	}
}
