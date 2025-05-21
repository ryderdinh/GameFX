using System;
using System.Collections.Generic;
using Core.Server;
using DB;
using MS.Casual.IAP;
using UnityEngine;
using UnityEngine.Purchasing;

namespace MS.Store
{
	[CreateAssetMenu(fileName = "IAPStore", menuName = "Store/IAP Store")]
	public class IAPStore : ScriptableObject, IStoreListener, IPurchaseVerification
	{
		[SerializeField]
		private FakeStoreUIMode FakeStoreUIMode;

		[SerializeField]
		private IAPVerification IAPVerification;

		[SerializeField]
		private List<InAppItemData> IAPItems;

		[SerializeField]
		private InAppItemData[] _inAppsToRestore;

		[SerializeField]
		private IAPRecordBook IAPRecordBook;

		[SerializeField]
		private UserStateBackup _userStateBackup;

		[SerializeField]
		private DBBool PremiumUser;

		[NonSerialized]
		private ConfigurationBuilder _configurationBuilder;

		[NonSerialized]
		private StandardPurchasingModule _purchasingModule;

		[NonSerialized]
		private IStoreController _storeController;

		[NonSerialized]
		private IExtensionProvider _extensionProvider;

		private TransactionRecord _purchasedProduct;

		private MonoBehaviour _crRunner;

		private RestoreStatus _restoreStatus;

		public bool IsInitialized => false;

		public void Initialize(MonoBehaviour crRunner)
		{
		}

		private void RegisterEvents()
		{
		}

		private void PurchaseProduct(string productId)
		{
		}

		public InAppItemData GetIAPItem(string id)
		{
			return null;
		}

		public string GetLocalizePrice(string id)
		{
			return null;
		}

		public string GetLocalizePrice(Product product)
		{
			return null;
		}

		public Product GetProduct(string id)
		{
			return null;
		}

		private void SetupStoreConfigurationBuilder()
		{
		}

		private void AssignProductsToItems()
		{
		}

		void IStoreListener.OnInitialized(IStoreController controller, IExtensionProvider extensions)
		{
		}

		void IStoreListener.OnInitializeFailed(InitializationFailureReason error, string message)
		{
		}

		void IStoreListener.OnInitializeFailed(InitializationFailureReason error)
		{
		}

		void IStoreListener.OnPurchaseFailed(Product product, PurchaseFailureReason failureReason)
		{
		}

		private void ForcePurchaseProduct(IAPRecordStatus status)
		{
		}

		PurchaseProcessingResult IStoreListener.ProcessPurchase(PurchaseEventArgs purchaseEvent)
		{
			return default(PurchaseProcessingResult);
		}

		private void SkipVerification(IAPRecord iAPRecord)
		{
		}

		private void VerifyPurchaseRecord(IAPRecord iAPRecord)
		{
		}

		private void RestorePurchases()
		{
		}

		private void OnTransactionsRestored(bool success, string message)
		{
		}

		private void ReportPurchaseSuccess(IAPRecord iAPRecord, IAPRecordStatus status)
		{
		}

		void IPurchaseVerification.PurchaseVerificationSuccess(IAPRecord iAPRecord)
		{
		}

		void IPurchaseVerification.PurchaseVerificationInvalid(IAPRecord iAPRecord)
		{
		}

		void IPurchaseVerification.PurchaseVerificationSuccessOnTest(IAPRecord iAPRecord)
		{
		}

		void IPurchaseVerification.PurchaseVerificationUnknown(IAPRecord iAPRecord)
		{
		}

		void IPurchaseVerification.PurchaseVerificationSkip(IAPRecord iAPRecord)
		{
		}

		void IPurchaseVerification.PurchaseVerificationFailed(IAPRecord iAPRecord)
		{
		}

		private void AutoRestore()
		{
		}

		private void ManualRestore()
		{
		}

		private void ManualRestoreProduct(string id, string productID)
		{
		}

		private void OnFetchProductEvent(string id, Action<TransactionRecord> callback)
		{
		}

		public List<IAPRecord> GetRecords(List<string> searchRecords)
		{
			return null;
		}

		public void UpdateRecordStatus(List<IAPRecord> iAPRecords, IAPRecordStatus iAPRecordStatus)
		{
		}
	}
}
