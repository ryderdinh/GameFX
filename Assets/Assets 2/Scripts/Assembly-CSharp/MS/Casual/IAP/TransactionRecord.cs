using System;
using UnityEngine.Purchasing;

namespace MS.Casual.IAP
{
	[Serializable]
	public class TransactionRecord
	{
		public string TransactionID;

		public string SkuId;

		public string StoreSpecificId;

		public string Status;

		public string Time;

		public string Receipt;

		public string CurrencyCode;

		public decimal LocalizedPrice;

		public string LocalizedStringPrice;

		public string LocalizedTitle;

		public TransactionRecord(Product product)
		{
		}

		public void UpdateStatus(TransactionStatus status)
		{
		}

		public bool IsPendingRecord()
		{
			return false;
		}

		public static TransactionRecord[] ParseList(Product[] products)
		{
			return null;
		}

		public bool HasReceipt()
		{
			return false;
		}
	}
}
