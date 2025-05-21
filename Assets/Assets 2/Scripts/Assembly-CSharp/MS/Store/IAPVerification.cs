using System;
using UnityEngine;

namespace MS.Store
{
	public abstract class IAPVerification : ScriptableObject
	{
		[NonSerialized]
		public IPurchaseVerification PurchaseVerificationListener;

		[NonSerialized]
		public IAPRecord IAPRecord;

		public abstract void VerifyPurchase(IAPRecord iAPRecord);
	}
}
