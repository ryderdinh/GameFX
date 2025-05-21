using System;
using System.Collections.Generic;
using DB;
using UnityEngine;

namespace MS.Casual.Ads
{
	[CreateAssetMenu(fileName = "InGameInterstitialAdObject", menuName = "ScriptableObjects/Ads/InGameInterstitialAdObject")]
	public class InGameInterstitialAdObject : BaseAdsObject
	{
		[SerializeField]
		private PowerUpsSystem _powerUpsSystem;

		[SerializeField]
		private TurboModeSystem _turboModeSystem;

		[SerializeField]
		private ScoreSystem _scoreSystem;

		[SerializeField]
		private LevelSystem _levelSystem;

		[SerializeField]
		private CashObject _cashObject;

		[SerializeField]
		private int _coinsRewardToGive;

		[SerializeField]
		private Vector3 _rewardPosition;

		[SerializeField]
		private List<int> _showOfferCounter;

		[SerializeField]
		private float _delayToShowOffer;

		[SerializeField]
		private UserJourneySystem _userJourneySystem;

		[SerializeField]
		private DBInt _intersIndex;

		[SerializeField]
		private ContextualOffersObject _offersController;

		private DateTime _lastInGameInterTime;

		private int _intersCount;

		private bool _isAdShown;

		private int _currentCounterIndex;

		private int _intersShownCount;

		private int _startingPotsCount;

		private Camera _mainCamera;

		public override void Initialize(IAdNetwork adNetwork)
		{
		}

		public void ResetInGameIntersitials(bool hardReset)
		{
		}

		public void ShowAdsLoadingView()
		{
		}

		private void InitializeEvents()
		{
		}

		public void OnInterstitialClosed(bool result)
		{
		}

		private void ShowOffer()
		{
		}

		private void OnInterstitialClosed(string args, MaxSdkBase.AdInfo info)
		{
		}

		private void GiveReward()
		{
		}

		private void HideInterstitialLoading()
		{
		}

		private void OnRvClosed(string args, MaxSdkBase.AdInfo info)
		{
		}

		private void ResetTimer()
		{
		}

		private void OnInterstitialFailedToDisplay(string args, MaxSdkBase.ErrorInfo errorCode, MaxSdkBase.AdInfo info)
		{
		}

		private bool EnoughPotsPlaced()
		{
			return false;
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
