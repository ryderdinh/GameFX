using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace MS.Casual.Ads
{
	[CreateAssetMenu(fileName = "InterstitialAdObject", menuName = "ScriptableObjects/Ads/InterstitialAdObject")]
	public class InterstitialAdObject : BaseAdsObject
	{
		[CompilerGenerated]
		private sealed class _003CInterstitialTimeOut_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public InterstitialAdObject _003C_003E4__this;

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
			public _003CInterstitialTimeOut_003Ed__25(int _003C_003E1__state)
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
		private ScoreSystem _scoreSystem;

		[SerializeField]
		private UserJourneySystem _userJourneySystem;

		private DateTime _lastDisplayInterstitialTime;

		private Action<bool> _actionToCallOnInterstitialClose;

		private bool _canShowInterstitial;

		private bool _canShowOfferOnClose;

		private Coroutine _interstitialTimeoutCoroutine;

		private WaitForSecondsRealtime _interTimeOutWait;

		private WaitForSeconds _inGameIntersDelay;

		private MonoBehaviour _coroutineRunner;

		private AdEventData _adEventData;

		public void Initialize(IAdNetwork adNetwork, MonoBehaviour mono)
		{
		}

		private void InitializeEvents()
		{
		}

		private bool ShowInGameInterstitial(AdEventData adEventData)
		{
			return false;
		}

		private void ShowInterstitial(string placement)
		{
		}

		private bool ShowInterstitialWithTimer(AdEventData adEventData)
		{
			return false;
		}

		private bool ShowInterstitial(AdEventData adEventData)
		{
			return false;
		}

		private void OnInterstitialClosed(string args)
		{
		}

		private void Reset()
		{
		}

		private void StopTimeOutCR()
		{
		}

		private void OnRvClosed(string args, MaxSdkBase.AdInfo info)
		{
		}

		private void OnAppOpenClosed(string args, MaxSdkBase.AdInfo info)
		{
		}

		private void OnInterstitialClosed(string args, MaxSdkBase.AdInfo info)
		{
		}

		private void OnInterstitialFailedToDisplay(string args, MaxSdkBase.ErrorInfo errorCode, MaxSdkBase.AdInfo info)
		{
		}

		private void InvokeCloseCallback(bool result)
		{
		}

		[IteratorStateMachine(typeof(_003CInterstitialTimeOut_003Ed__25))]
		private IEnumerator InterstitialTimeOut()
		{
			return null;
		}

		public override bool ShowAd(AdEventData adEventData)
		{
			return false;
		}

		public override void HideAd(AdEventData adEventData)
		{
		}

		public override bool IsAdLoaded()
		{
			return false;
		}

		public override bool IsAdUnlocked()
		{
			return false;
		}

		public override bool CanShowAd()
		{
			return false;
		}
	}
}
