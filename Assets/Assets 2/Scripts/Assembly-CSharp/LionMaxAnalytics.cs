using System.Threading.Tasks;
using LionStudios.Suite.Core;

public class LionMaxAnalytics : ILionSdk, ILionSettingsProvider
{
	private static AnalyticsSettings _settings;

	protected BaseLionMaxAnalytics _interstitialAnalytics;

	protected BaseLionMaxAnalytics _rewardedAnalytics;

	protected BaseLionMaxAnalytics _bannerAnalytics;

	int ILionSdk.Priority => 0;

	string ILionSettingsProvider.Name => null;

	void ILionSettingsProvider.ApplySettings(ILionSettingsInfo newSettings)
	{
	}

	string[] ILionSdk.GetPrivacyLinks()
	{
		return null;
	}

	ILionSettingsInfo ILionSettingsProvider.GetSettings()
	{
		return null;
	}

	bool ILionSdk.IsInitialized()
	{
		return false;
	}

	Task ILionSdk.Initialize(LionCoreContext ctx)
	{
		return null;
	}

	void ILionSdk.OnPostInitialize(LionCoreContext ctx)
	{
	}

	void ILionSdk.OnPreInitialize(LionCoreContext ctx)
	{
	}
}
