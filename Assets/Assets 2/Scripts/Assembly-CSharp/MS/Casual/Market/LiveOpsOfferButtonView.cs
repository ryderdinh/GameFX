using Analytics;
using UnityEngine;
using UnityEngine.UI;

namespace MS.Casual.Market
{
	public class LiveOpsOfferButtonView : MonoBehaviour
	{
		[SerializeField]
		private Button _specialOfferButton;

		[SerializeField]
		private ContextualOffersObject _contextualOffers;

		[SerializeField]
		private LiveOpsSystem _liveOpsSystem;

		[SerializeField]
		private GameObject _container;

		[SerializeField]
		private AnalyticsSystem _analyticsSystem;

		private ISpecialOffer _listener;

		private GameObject _animatedIcon;

		public void Initialize()
		{
		}

		public void Show()
		{
		}

		public void Hide()
		{
		}

		private void UpdateNewOffer()
		{
		}

		private void RegisterEvents()
		{
		}

		private void OnOfferCooldownStateChangedEvent(CooldownStateDataModel model)
		{
		}

		private void SpecialOfferButtonClicked()
		{
		}

		private void PlayButtonImpact()
		{
		}
	}
}
