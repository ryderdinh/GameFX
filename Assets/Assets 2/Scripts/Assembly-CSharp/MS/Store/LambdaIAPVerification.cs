using System;
using UnityEngine;

namespace MS.Store
{
	[CreateAssetMenu(fileName = "LambdaIAPVerification", menuName = "Store/LambdaIAPVerification")]
	public class LambdaIAPVerification : IAPVerification
	{
		[Serializable]
		public class IAPServerResponse
		{
			public string env;

			public string platform;

			public string message;
		}

		[Serializable]
		private class TransactionReceipt
		{
			public string Store;

			public string TransactionID;

			public string Payload;
		}

		[Serializable]
		private class GooglePlayReceipt
		{
			public string json;

			public string signature;
		}

		[Serializable]
		private class GoogleTransactionReceipt
		{
			public string purchaseToken;
		}

		private static readonly string PACKAGE_NAME;

		[SerializeField]
		private RemoteAppConfig _remoteAppConfig;

		public override void VerifyPurchase(IAPRecord iAPRecord)
		{
		}

		public bool CanSkipVerification()
		{
			return false;
		}
	}
}
