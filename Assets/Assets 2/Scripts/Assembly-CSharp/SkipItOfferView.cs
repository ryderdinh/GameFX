using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using MS.Casual.IAP;
using MSKit.UIView;
using UnityEngine;

public class SkipItOfferView : BaseUIViewController<SkipItOfferViewRefs>
{
	[CompilerGenerated]
	private sealed class _003CHandleTimeCounter_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkipItOfferView _003C_003E4__this;

		public TimeSpan remainingTime;

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
		public _003CHandleTimeCounter_003Ed__21(int _003C_003E1__state)
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

	private WaitForSeconds _waitOneSec;

	private TransactionRecord _product;

	private bool _priceInitialized;

	private DateTime _initializeTime;

	private Coroutine _timerCR;

	private ISkipAdsPurchaseView _skipAdsPurchaseViewHandler;

	public override void Initialize()
	{
	}

	private void InitializePrice()
	{
	}

	public override void Show(object model = null)
	{
	}

	public override void Hide()
	{
	}

	public override void RegisterEvents()
	{
	}

	public override void UnregisterEvents()
	{
	}

	public override void InitializeTexts()
	{
	}

	public override void InitializeButtons()
	{
	}

	private void StartTimerCR()
	{
	}

	private void StopTimerCR()
	{
	}

	private void UpdateOfferData()
	{
	}

	private void OnInAppInitialize(TransactionRecord[] products)
	{
	}

	private void SetOfferPrice()
	{
	}

	private void PurchaseClicked()
	{
	}

	private void CloseView()
	{
	}

	[IteratorStateMachine(typeof(_003CHandleTimeCounter_003Ed__21))]
	private IEnumerator HandleTimeCounter(TimeSpan remainingTime)
	{
		return null;
	}

	private void SetCloseButton()
	{
	}

	private void WatchAd()
	{
	}
}
