using System;
using UnityEngine.Purchasing;

namespace MS.Store
{
	[Serializable]
	public class IAPRecord
	{
		public string TransactionID;

		public string SkuId;

		public string Status;

		public string Time;

		public string Payload;

		[NonSerialized]
		public Product PurchasedProduct;

		public bool IsValid => false;

		public IAPRecordStatus IAPRecordStatus => default(IAPRecordStatus);

		public IAPRecord(PurchaseEventArgs purchaseEventArgs)
		{
		}

		public void UpdateStatus(IAPRecordStatus status)
		{
		}

		private static IAPRecordStatus StatusFromString(string status)
		{
			return default(IAPRecordStatus);
		}
	}
}
