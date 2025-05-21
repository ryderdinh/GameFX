using Analytics;
using DB;
using UnityEngine;
using com.adjust.sdk;

public class LionKitInit : MonoBehaviour
{
	public const string ADJUST_APP_KEY = "3wmp35sselts";

	[SerializeField]
	private AnalyticsSystem _analyticsSystem;

	[SerializeField]
	private DBBool AmazonTestAdsEnabled;

	[SerializeField]
	private AppConfig _appConfig;

	private const string MAX_SDK_KEY = "hlKffQFn1sKXRefAUUKG4o-i-OOURETonfImCKvE29oyDwftIiyhVZMlNNxwUFl8NgUmynX33XOEq5m09yb34Z";

	private static LionKitInit _lionKitInstance;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private bool ToggleAmazonTestAds()
	{
		return false;
	}

	private void InitializeMax()
	{
	}

	private string GetDeviceId()
	{
		return null;
	}

	private void InitAmazon()
	{
	}

	private void OnMaxSDKInitialized(MaxSdkBase.SdkConfiguration obj)
	{
	}

	private void InitializeAnalytics()
	{
	}

	private void AttributionChangedDelegate(AdjustAttribution attribution)
	{
	}

	private void SetAdvertiserTrackingStatus(MaxSdkBase.SdkConfiguration configs)
	{
	}
}
