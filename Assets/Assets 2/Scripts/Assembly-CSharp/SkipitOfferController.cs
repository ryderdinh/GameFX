using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using MS.Casual.Market;
using UnityEngine;

public class SkipitOfferController : IIApp
{
	[CompilerGenerated]
	private sealed class _003CInitializeCR_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkipitOfferController _003C_003E4__this;

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
		public _003CInitializeCR_003Ed__5(int _003C_003E1__state)
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

	private IAPHandler _iAPHandler;

	private MonoBehaviour _coroutineRunner;

	public SkipitOfferController(MonoBehaviour mono)
	{
	}

	private void InitializeEvents()
	{
	}

	private void OnSkipItOfferPurchased()
	{
	}

	[IteratorStateMachine(typeof(_003CInitializeCR_003Ed__5))]
	private IEnumerator InitializeCR()
	{
		return null;
	}

	public void PurchaseSuccessfull(bool isRestore)
	{
	}

	public void PurchaseFailed()
	{
	}
}
