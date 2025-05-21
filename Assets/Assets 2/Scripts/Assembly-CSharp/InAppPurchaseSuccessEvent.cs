using MS.Casual.IAP;
using MS.Store;
using UnityEngine.Events;

public class InAppPurchaseSuccessEvent : UnityEvent<TransactionRecord, RestoreStatus, IAPRecordStatus>
{
}
