using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using SRDebugger;
using UnityEngine;
using UnityEngine.Scripting;

[Preserve]
public class SROptions : INotifyPropertyChanged
{
	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property)]
	public sealed class DisplayNameAttribute : System.ComponentModel.DisplayNameAttribute
	{
		public DisplayNameAttribute(string displayName)
		{
		}
	}

	[AttributeUsage(AttributeTargets.Property)]
	public sealed class IncrementAttribute : SRDebugger.IncrementAttribute
	{
		public IncrementAttribute(double increment)
			: base(0.0)
		{
		}
	}

	[AttributeUsage(AttributeTargets.Property)]
	public sealed class NumberRangeAttribute : SRDebugger.NumberRangeAttribute
	{
		public NumberRangeAttribute(double min, double max)
			: base(0.0, 0.0)
		{
		}
	}

	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property)]
	public sealed class SortAttribute : SRDebugger.SortAttribute
	{
		public SortAttribute(int priority)
			: base(0)
		{
		}
	}

	private static SROptions _current;

	private static SoundsData _soundsData;

	private float _boosterCallDelay;

	public static SROptions Current => null;

	[Category("Active Booster Call Delay")]
	public float BoosterCallDelay
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	[Category("Add Flower Card")]
	[NumberRange(0.0, 5.0)]
	public int FlowerID { get; set; }

	[Category("Add Flower Card")]
	public int FlowerCardsCount { get; set; }

	[NumberRange(1.0, 100.0)]
	[Category("Sounds")]
	public float VolumeMultiplier { get; set; }

	[NumberRange(0.0, 100.0)]
	[Category("Pre Population Preset")]
	public int PrePopulationPresetID { get; set; }

	[Category("ButterflyRewardDrop")]
	public float BoosterJumpScale { get; set; }

	[Category("ButterflyRewardDrop")]
	public int DisappearTime { get; set; }

	[Category("ButterflyRewardDrop")]
	public int BoosterJumpPower { get; set; }

	[Category("ButterflyRewardDrop")]
	public float BoosterJumpDuration { get; set; }

	[NumberRange(0.0, 10.0)]
	[Category("Optimization")]
	public int RenderScaleValue { get; set; }

	public event SROptionsPropertyChanged PropertyChanged
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private event PropertyChangedEventHandler InterfacePropertyChangedEventHandler
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	event PropertyChangedEventHandler INotifyPropertyChanged.PropertyChanged
	{
		add
		{
		}
		remove
		{
		}
	}

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
	public static void OnStartup()
	{
	}

	public void OnPropertyChanged(string propertyName)
	{
	}

	private void Close()
	{
	}

	[Category("Add Flower Card")]
	public void AddFlowerCard()
	{
	}

	[Category("Enable Adjust Test Events")]
	public void EnableAdjustTestEvents()
	{
	}

	[Category("Dish Tier Increment Booster")]
	public void IncrementDishTier()
	{
	}

	[Category("Active Boosters")]
	public void ApplyWaterCan()
	{
	}

	[Category("Active Boosters")]
	public void ApplySuperWaterCan()
	{
	}

	[Category("Active Boosters")]
	public void ApplyBomb()
	{
	}

	[Category("Active Boosters")]
	public void ApplyTrovel()
	{
	}

	[Category("Active Boosters")]
	public void ApplyColumnSort()
	{
	}

	[Category("Active Boosters")]
	public void ApplyRowSort()
	{
	}

	[Category("Active Boosters")]
	public void ApplyHorizontalRocket()
	{
	}

	[Category("Active Boosters")]
	public void ApplyVerticalRocket()
	{
	}

	[Category("Active Boosters")]
	public void ApplyHorizontalVerticalRocket()
	{
	}

	[Category("Active Boosters")]
	public void ApplyLargeFertilizer()
	{
	}

	[Category("Active Boosters")]
	public void ApplySmallFertilizer()
	{
	}

	[Category("Active Boosters")]
	public void ApplySuperMagicPot()
	{
	}

	[Category("Active Boosters")]
	public void ApplyMagicPot()
	{
	}

	[Category("Active Boosters")]
	public void ApplyPaintBrush()
	{
	}

	[Category("Active Boosters")]
	public void ApplyPitchFork()
	{
	}

	[Category("Active Boosters")]
	public void ApplyRespawnTrays()
	{
	}

	[Category("Active Boosters")]
	public void ApplySwapSlots()
	{
	}

	[Category("Active Boosters")]
	public void ApplyWheelBarrow()
	{
	}

	[Category("Active Boosters")]
	public void ApplyItemBonusScore()
	{
	}

	[Category("Active Boosters")]
	public void ApplySlotUnlockBooster()
	{
	}

	[Category("Active Boosters")]
	public void ApplyCoinsBooster()
	{
	}

	[Category("Active Boosters")]
	public void ApplySexyPotBooster()
	{
	}

	[Category("Booster FTUE Logs")]
	public void PrintFTUELogs()
	{
	}

	[Category("Inters On")]
	public void IntersOn()
	{
	}

	[Category("Inters Off")]
	public void IntersOff()
	{
	}

	[Category("Banners On")]
	public void BannersOn()
	{
	}

	[Category("Banners Off")]
	public void BannersOff()
	{
	}

	[Category("Skip Its")]
	public void Add10SkipIts()
	{
	}

	[Category("Coins")]
	public void Add1000Coins()
	{
	}

	[Category("Sounds")]
	public void UpdateVolumeMultiplier()
	{
	}

	[Category("Max Sdk")]
	public void OpenMaxDebugger()
	{
	}

	[Category("Amazon Test Ads")]
	public void ToggleAmazonTestAds()
	{
	}

	[Category("Increment MetaID")]
	public void AddLevelScore()
	{
	}

	[Category("Clear Prefs")]
	public void ClearPrefs()
	{
	}

	[Category("Clear Prefs")]
	public void ClearServerPrefs()
	{
	}

	[Category("Pre Population Preset")]
	public void ApplyPreset()
	{
	}

	[Category("Butterfly Flow")]
	public void EnableButterflySpinnerFlow()
	{
	}

	[Category("Butterfly Flow")]
	public void EnableButterflyDropFlow()
	{
	}

	[Category("ButterflyRewardDrop")]
	public void UpdateRewardDisappearTime()
	{
	}

	[Category("ButterflyRewardDrop")]
	public void UpdateRewardDropConfigs()
	{
	}

	[Category("Optimization")]
	public void ApplyRenderScale()
	{
	}
}
