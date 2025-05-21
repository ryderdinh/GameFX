public abstract class BaseLionMaxAnalytics
{
	public BaseLionMaxAnalytics()
	{
	}

	protected abstract void InitializeEvents();

	protected abstract void OnAdLoaded(string adUnit, MaxSdkBase.AdInfo adInfo);

	protected abstract void OnAdLoadFail(string adUnit, MaxSdkBase.ErrorInfo errorInfo);

	protected abstract void OnAdDisplayed(string adUnit, MaxSdkBase.AdInfo adInfo);

	protected abstract void OnAdDisplayFailed(string adUnit, MaxSdkBase.ErrorInfo errorInfo, MaxSdkBase.AdInfo adInfo);
}
