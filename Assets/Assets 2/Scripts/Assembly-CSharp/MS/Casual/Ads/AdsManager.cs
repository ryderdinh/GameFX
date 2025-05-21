using UnityEngine;

namespace MS.Casual.Ads
{
	public class AdsManager : MonoBehaviour
	{
		private IAdNetwork _adNetwork;

		[SerializeField]
		private AdsObject _adsObject;

		private static AdsManager _instance;

		private void Awake()
		{
		}

		private void CreateAdNetwork()
		{
		}

		private void InitializeEvents()
		{
		}

		private void ResetTimers(bool hardReset)
		{
		}

		private void HardResetTimers()
		{
		}
	}
}
