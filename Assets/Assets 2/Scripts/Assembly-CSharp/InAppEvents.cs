using System;
using MS.Casual.IAP;
using MS.Store;
using UnityEngine.Purchasing;

public static class InAppEvents
{
	public static InAppInitializedEvent InAppsInitialized;

	public static InAppProcessedEvent ProductProcessedEvent;

	public static InAppProductEvent PurchaseProductEvent;

	public static InAppPurchaseSuccessEvent PurchaseSuccessEvent;

	public static InAppProductPurchaseInitiateEvent PurchaseInitiateEvent;

	public static InAppPurchaseFailEvent PurchaseFailedEvent;

	public static InAppBooleanEvent InAppWaitOverlayEvent;

	public static InAppEvent RestoreInAppEvent;

	public static InAppProductInfoEvent OnFetchProductInfo;

	public static InAppProductVerificationEvent InAppVerificationEvent;

	public static void DoFireInAppsInitializedEvent(TransactionRecord[] products)
	{
	}

	public static void DoFireInAppProcessedEvent(TransactionRecord product)
	{
	}

	public static void DoFirePurchaseProductEvent(string productId)
	{
	}

	public static void DoFirePurchaseSuccessEvent(TransactionRecord product, RestoreStatus restoreStatus, IAPRecordStatus status)
	{
	}

	public static void DoFirePurchaseInitiateEvent(TransactionRecord product)
	{
	}

	public static void DoFirePurchaseFailedEvent(TransactionRecord product, PurchaseFailureReason reason)
	{
	}

	public static void DoFireInAppWaitOverlayEvent(bool state)
	{
	}

	public static void DoFireRestoreInAppEvent()
	{
	}

	public static void DoFireOnFetchProductInfoEvent(string productId, Action<TransactionRecord> callback)
	{
	}

	public static void DoFireInAppVerificationEvent(IAPRecordStatus status)
	{
	}
}
