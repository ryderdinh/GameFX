using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using MS.Casual.IAP;
using MS.Store;
using UnityEngine;
using UnityEngine.Purchasing;

namespace MS.Casual.Market
{
	public class IAPHandler
	{
		[CompilerGenerated]
		private sealed class _003CInitializeInApp_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public IAPHandler _003C_003E4__this;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CInitializeInApp_003Ed__8(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		private MonoBehaviour _coroutineRunner;

		private TransactionRecord _product;

		private string _productId;

		private IIApp _iAppHandler;

		public IAPHandler(IIApp iApp, MonoBehaviour mono, string productId)
		{
		}

		public bool PurchaseProduct()
		{
			return false;
		}

		public void ReInitialize(string productId)
		{
		}

		private void InitializeEvents()
		{
		}

		[IteratorStateMachine(typeof(_003CInitializeInApp_003Ed__8))]
		private IEnumerator InitializeInApp()
		{
			return null;
		}

		private void Initialize()
		{
		}

		private void OnInAppsInitialized(TransactionRecord[] products)
		{
		}

		private void OnPurchaseSuccess(TransactionRecord product, RestoreStatus restoreStatus, IAPRecordStatus status)
		{
		}

		private void OnPurchaseFailed(TransactionRecord product, PurchaseFailureReason reason)
		{
		}
	}
}
