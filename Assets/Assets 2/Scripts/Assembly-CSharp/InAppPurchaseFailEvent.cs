using MS.Casual.IAP;
using UnityEngine.Events;
using UnityEngine.Purchasing;

public class InAppPurchaseFailEvent : UnityEvent<TransactionRecord, PurchaseFailureReason>
{
}
