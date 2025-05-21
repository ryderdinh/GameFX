using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using MS.Casual.IAP;
using MSKit.UIView;
using UnityEngine;

namespace MS.Casual.Market
{
	public abstract class BaseFullScreenOfferView<T> : BaseUIViewController<T> where T : BaseFullScreenOfferViewRefs
	{
		[CompilerGenerated]
		private sealed class _003CHandleTimeCounter_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public BaseFullScreenOfferView<T> _003C_003E4__this;

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
			public _003CHandleTimeCounter_003Ed__20(int _003C_003E1__state)
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

		private readonly WaitForSeconds _waitOneSec;

		protected ISpecialOffer _listener;

		private Coroutine _timerRoutine;

		private TransactionRecord _product;

		private bool _priceInitialized;

		private GameObject _animatedIcon;

		private Action _callBack;

		public override void Show(object model = null)
		{
		}

		private void InitializePrice()
		{
		}

		public override void Hide()
		{
		}

		private void SetCloseButton()
		{
		}

		protected virtual void OnCloseButtonClicked()
		{
		}

		private void PurchaseClicked()
		{
		}

		protected virtual void CloseView()
		{
		}

		private void OnInAppInitialize(TransactionRecord[] products)
		{
		}

		protected virtual void SetDataWithOffer(ISpecialOffer iSpecialOffer)
		{
		}

		protected virtual void StartOfferTimer(SpecialOfferTimeController Timer)
		{
		}

		protected virtual void SetTextColors(Material material)
		{
		}

		protected virtual void SetOfferPrice()
		{
		}

		protected virtual void UpdateRewardData()
		{
		}

		[IteratorStateMachine(typeof(BaseFullScreenOfferView<>._003CHandleTimeCounter_003Ed__20))]
		private IEnumerator HandleTimeCounter(TimeSpan remainingTime)
		{
			return null;
		}

		private void StopTimerCR()
		{
		}

		public override void InitializeTexts()
		{
		}

		public override void RegisterEvents()
		{
		}

		public override void UnregisterEvents()
		{
		}

		public override void InitializeButtons()
		{
		}
	}
}
