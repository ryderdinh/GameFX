using System;
using System.Collections.Generic;
using UnityEngine.Purchasing;

namespace MS.Casual.IAP
{
	[Serializable]
	public class TransactionRecordList
	{
		public List<TransactionRecord> DataList;

		public void AddItem(Product product)
		{
		}

		public TransactionRecord GetLastItem()
		{
			return null;
		}

		public void UpdateItem(string transactionId, TransactionStatus status)
		{
		}
	}
}
