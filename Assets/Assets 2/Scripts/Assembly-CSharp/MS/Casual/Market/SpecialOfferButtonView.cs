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
	public class SpecialOfferButtonView : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CHandleTimeCounter_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public SpecialOfferButtonView _003C_003E4__this;

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
			public _003CHandleTimeCounter_003Ed__22(int _003C_003E1__state)
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
		private Button _specialOfferButton;

		[SerializeField]
		private TextMeshProUGUI _remainingTimeText;

		[SerializeField]
		private Transform _specialOfferTransform;

		[SerializeField]
		private Transform _transform;

		[SerializeField]
		private RectTransform _iconParentRectTransform;

		[SerializeField]
		private GameObject _saleTag;

		[SerializeField]
		private ContextualOffersObject _contextualOffers;

		[SerializeField]
		private Transform _specialOfferPositionTop;

		[SerializeField]
		private Transform _specialOfferPositionBottom;

		private readonly WaitForSeconds _waitOneSec;

		private ISpecialOffer _listener;

		private Vector3 _viewInitialPosition;

		private Coroutine _timerRoutine;

		private GameObject _animatedIcon;

		public void Initialize()
		{
		}

		public void Show()
		{
		}

		private void SetPosition()
		{
		}

		public void Hide()
		{
		}

		private void UpdateNewOffer()
		{
		}

		private void StopTimerCR()
		{
		}

		private void LoadIcon()
		{
		}

		private void LoadOfferTime(SpecialOfferTimeController Timer)
		{
		}

		[IteratorStateMachine(typeof(_003CHandleTimeCounter_003Ed__22))]
		private IEnumerator HandleTimeCounter(TimeSpan remainingTime)
		{
			return null;
		}

		private void RegisterEvents()
		{
		}

		private void OnOfferCooldownStateChangedEvent(CooldownStateDataModel model)
		{
		}

		private void OnStarterPackAvailabilityChangedEvent(bool state)
		{
		}

		private void SpecialOfferButtonClicked()
		{
		}

		private void FireInteractionEvent(string name)
		{
		}

		private void PlayButtonImpact()
		{
		}

		public void MoveOutView(float delta)
		{
		}

		public void ForceMoveOutView(float delta)
		{
		}

		public void MoveInView(float delta)
		{
		}
	}
}
