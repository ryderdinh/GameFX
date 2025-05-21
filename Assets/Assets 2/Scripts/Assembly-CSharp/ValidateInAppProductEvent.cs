using System;
using MS.Casual.IAP;
using UnityEngine.Events;

public class ValidateInAppProductEvent : UnityEvent<TransactionRecord, Action<bool>>
{
}
