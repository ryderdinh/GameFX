using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using MSKit.UIView;
using UnityEngine;

public class PowerUpsSpinnerView : BaseUIViewController<PowerUpsSpinnerViewRefs>, IBoosterSpinner
{
	[CompilerGenerated]
	private sealed class _003CPointerDownAndHoldCoroutine_003Ed__44 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PowerUpsSpinnerView _003C_003E4__this;

		private WaitForSeconds _003CwaitForSeconds_003E5__2;

		private bool _003CisPressedAndHold_003E5__3;

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
		public _003CPointerDownAndHoldCoroutine_003Ed__44(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CTutorialHandCoroutine_003Ed__52 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PowerUpsSpinnerView _003C_003E4__this;

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
		public _003CTutorialHandCoroutine_003Ed__52(int _003C_003E1__state)
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
	private GiftSpawnerSystem _giftSpawnerSystem;

	private DateTime _pointerDownTime;

	private bool _isPressed;

	private bool _isSpinning;

	private bool _canPressAndHold;

	private float _pressAndHoldTime;

	private List<Vector3> _spinnerDefaultPositions;

	private Vector3 _headDefaultPosition;

	private Vector3 _topBannerDefaultPosition;

	private Vector3 _pressAndHoldPosition;

	private LevelUpGiftData _levelUpGiftData;

	private int _respinCount;

	private int _skipRespinCount;

	private int _rewardCount;

	private int _headerYUpPosition;

	private Coroutine _pressAndHoldCoroutine;

	private Coroutine _handTutorialCoroutine;

	private Sequence stopSpinningsequence;

	private Sequence _cardBounceSequence;

	private List<BoostersTypes> _ignoreBoostersType;

	public override void InitializeButtons()
	{
	}

	public override void InitializeTexts()
	{
	}

	public override void RegisterEvents()
	{
	}

	public override void UnregisterEvents()
	{
	}

	public override void Initialize()
	{
	}

	public override void Show(object model = null)
	{
	}

	private Vector3 GetGiftBoxUIPosition()
	{
		return default(Vector3);
	}

	private void LoadSkipRespinData()
	{
	}

	private void SetInitialData()
	{
	}

	private void ShowAnimation()
	{
	}

	private void SetSpinnersSizeAdjustment()
	{
	}

	private void SetWatchAdsSpinningButtonState(bool state, float delay = 0f, bool instant = false)
	{
	}

	private void StartSpinning(bool isRespinning = false)
	{
	}

	private void StopSpinning()
	{
	}

	private void SpinningStopped()
	{
	}

	private void OnBoosterPointerDownAndHold()
	{
	}

	private void OnBoosterPointerUp()
	{
	}

	private void FadeCanvas(float value, float time)
	{
	}

	void IBoosterSpinner.BoosterSelected(ApplyBoosterData applyBoosterData)
	{
	}

	void IBoosterSpinner.HideSpinnersOnSelection(int id)
	{
	}

	private void BoostSelectionAnimation(ApplyBoosterData applyBoosterData)
	{
	}

	private void Respin(bool adWatched)
	{
	}

	public void OnPointerDown()
	{
	}

	public void OnPointerUp()
	{
	}

	[IteratorStateMachine(typeof(_003CPointerDownAndHoldCoroutine_003Ed__44))]
	private IEnumerator PointerDownAndHoldCoroutine()
	{
		return null;
	}

	private void StopCoroutine()
	{
	}

	private void CloseOnSelection()
	{
	}

	bool IBoosterSpinner.IsFTUE()
	{
		return false;
	}

	bool IBoosterSpinner.IsBestBooster()
	{
		return false;
	}

	bool IBoosterSpinner.IsIncrementFTUELevel()
	{
		return false;
	}

	private void CheckHandTutorial(bool isTutorial)
	{
	}

	private bool IsHandTutorialActive()
	{
		return false;
	}

	[IteratorStateMachine(typeof(_003CTutorialHandCoroutine_003Ed__52))]
	private IEnumerator TutorialHandCoroutine()
	{
		return null;
	}

	private void StopTutorialHandCoroutine()
	{
	}

	private void UpdateSkipAds(int count)
	{
	}
}
