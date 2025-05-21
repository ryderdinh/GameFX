using System;
using MS.Casual.IAP;
using UnityEngine.Events;

public class InAppProductInfoEvent : UnityEvent<string, Action<TransactionRecord>>
{
}
