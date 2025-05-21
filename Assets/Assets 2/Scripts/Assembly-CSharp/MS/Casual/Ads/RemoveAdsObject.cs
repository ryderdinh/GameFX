using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DB;
using MS.Casual.Market;
using MS.Store;
using UnityEngine;

namespace MS.Casual.Ads
{
	[CreateAssetMenu(fileName = "RemoveAdsObject", menuName = "ScriptableObjects/Ads/RemoveAdsObject")]
	public class RemoveAdsObject : ScriptableObject, IIApp
	{
		[CompilerGenerated]
		private sealed class _003CInitializeCR_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public RemoveAdsObject _003C_003E4__this;

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
			public _003CInitializeCR_003Ed__12(int _003C_003E1__state)
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
		private DBBool _adsState;

		[SerializeField]
		private AppConfig _appConfig;

		[SerializeField]
		private MetaSystem _metaSystem;

		[SerializeField]
		private UserJourneySystem _userJourneySystem;

		[SerializeField]
		private RemoveAdsIAPData[] _removeAdsIAPData;

		[SerializeField]
		private IAPStore _iapStore;

		[SerializeField]
		private string[] _restoreStrings;

		private bool _noAdsPurchased;

		private IRemoveAds _removeAdsHandler;

		private List<IAPHandler> _iAPHandlers;

		private MonoBehaviour _coroutineRunner;

		public void Initialize(IRemoveAds removeAdsHandler, MonoBehaviour mono)
		{
		}

		[IteratorStateMachine(typeof(_003CInitializeCR_003Ed__12))]
		private IEnumerator InitializeCR()
		{
			return null;
		}

		private void InitializeEvents()
		{
		}

		private void ValidateRemoveAds()
		{
		}

		public bool IsRemoveAdsPurchased()
		{
			return false;
		}

		public void PurchaseRemoveAds()
		{
		}

		public bool CanShowRemoveAdsOption()
		{
			return false;
		}

		public bool IsDiscountedOfferInProgress()
		{
			return false;
		}

		public float GetDiscountPercentage()
		{
			return 0f;
		}

		public MarketItemData GetCurrentMarketItemData()
		{
			return null;
		}

		public int GetRemoveAdsOfferInProgress()
		{
			return 0;
		}

		private void RemoveAdsPurchased()
		{
		}

		void IIApp.PurchaseSuccessfull(bool isRestore)
		{
		}

		void IIApp.PurchaseFailed()
		{
		}
	}
}
