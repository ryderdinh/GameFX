using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace MS.Casual.Market
{
	public class SpecialOfferInAppItemView : BundleInAppItemView
	{
		[CompilerGenerated]
		private sealed class _003CHandleTimeCounter_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public SpecialOfferInAppItemView _003C_003E4__this;

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
			public _003CHandleTimeCounter_003Ed__18(int _003C_003E1__state)
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

		[SerializeField]
		protected TextMeshProUGUI _remainingTimeText;

		[SerializeField]
		private TextMeshProUGUI _offerHeaderText;

		[SerializeField]
		private RectTransform _offerIconRectTransform;

		[SerializeField]
		private Image _offerCardBg;

		[SerializeField]
		private Image _offerCardTimerNotch;

		[SerializeField]
		private Offers _offerType;

		private ISpecialOffer _specialOffer;

		private GameObject _animatedIcon;

		private Coroutine timerRoutine;

		private WaitForSeconds waitOneSec;

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		public void OnItemShown(ISpecialOffer model)
		{
		}

		public void DeactivateBundle()
		{
		}

		private void UpdateNewOffer()
		{
		}

		private void StopTimerCR()
		{
		}

		protected virtual void LoadSpecialOfferData(ISpecialOffer iSpecialOffer)
		{
		}

		protected virtual void LoadOfferTimer(SpecialOfferTimeController Timer)
		{
		}

		[IteratorStateMachine(typeof(_003CHandleTimeCounter_003Ed__18))]
		private IEnumerator HandleTimeCounter(TimeSpan remainingTime)
		{
			return null;
		}

		protected virtual void RegisterEvents()
		{
		}

		protected virtual void UnRegisterEvents()
		{
		}

		protected override void BuyItem()
		{
		}
	}
}
