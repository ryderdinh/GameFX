using System;
using System.Collections.Generic;
using DB;
using UnityEngine;

namespace MS.Store
{
	[CreateAssetMenu(fileName = "IAPRecordBook", menuName = "Store/IAP Record Book")]
	public class IAPRecordBook : ScriptableObject
	{
		[SerializeField]
		private DBString InAppRecords;

		[NonSerialized]
		private IAPRecordList _iAPRecordList;

		public List<IAPRecord> GetPendingRecords()
		{
			return null;
		}

		public void AddRecord(IAPRecord record)
		{
		}

		public List<IAPRecord> GetRecords(List<string> searchRecords)
		{
			return null;
		}

		public void UpdateRecordStatus(IAPRecord iAPRecord, IAPRecordStatus iAPRecordStatus)
		{
		}

		public void UpdateRecordsStatus(List<IAPRecord> iAPRecords, IAPRecordStatus iAPRecordStatus)
		{
		}

		public void Save()
		{
		}

		public void Load()
		{
		}
	}
}
