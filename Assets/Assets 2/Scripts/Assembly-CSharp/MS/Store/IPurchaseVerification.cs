namespace MS.Store
{
	public interface IPurchaseVerification
	{
		void PurchaseVerificationSuccess(IAPRecord iAPRecord);

		void PurchaseVerificationSuccessOnTest(IAPRecord iAPRecord);

		void PurchaseVerificationInvalid(IAPRecord iAPRecord);

		void PurchaseVerificationFailed(IAPRecord iAPRecord);

		void PurchaseVerificationUnknown(IAPRecord iAPRecord);

		void PurchaseVerificationSkip(IAPRecord iAPRecord);
	}
}
