using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using MSKit.UIView;
using UnityEngine;

public class ButterflySpinnerView : BaseUIViewController<ButterflySpinnerViewRefs>, IBoosterSpinner
{
	[CompilerGenerated]
	private sealed class _003CPointerDownAndHoldCoroutine_003Ed__54 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ButterflySpinnerView _003C_003E4__this;

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
		public _003CPointerDownAndHoldCoroutine_003Ed__54(int _003C_003E1__state)
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
	private sealed class _003CTutorialHandCoroutine_003Ed__66 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ButterflySpinnerView _003C_003E4__this;

		private WaitForSeconds _003CtutWait_003E5__2;

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
		public _003CTutorialHandCoroutine_003Ed__66(int _003C_003E1__state)
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

	private int _respinsCount;

	private int _skipRespinCount;

	private int _freeSpinnerCount;

	private int _rewardCount;

	private bool _isFTUE;

	private bool _isPressed;

	private bool isSpinning;

	private bool _isWatchedAd;

	private bool _canPressAndHold;

	private float _pressAndHoldTime;

	private Sequence _idleSpinnerSequence;

	private Sequence _cardBounceSequence;

	private List<Vector3> _spinnerDefaultPositions;

	private List<BoostersTypes> _ignoreBoostersType;

	private DateTime _pointerDownTime;

	private Coroutine _pressAndHoldCoroutine;

	private Coroutine _handTutorialCoroutine;

	private Vector3 _butterflyDefaultPosition;

	private Vector3 _headDefaultPosition;

	private Vector3 _butterflyPositionOnBoard;

	private Vector3 _butterflySitPosition;

	private Vector3 _topBannerDefaultPosition;

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

	private void LoadFreeSpinData()
	{
	}

	private void LoadSkipRespinData()
	{
	}

	public override void Hide()
	{
	}

	private void GetButterflyUIPosition()
	{
	}

	private void SetInitialData()
	{
	}

	private void SetSpinnersSizeAdjustment()
	{
	}

	private void ShowAnimation()
	{
	}

	private void SetButtonState(GameObject container, bool state, bool isInstant = false, float delay = 0f)
	{
	}

	private void UpdateButterfly()
	{
	}

	private void StartSpinning(bool isRespinning = false)
	{
	}

	private void StartSpinningForFree(bool adWatched)
	{
	}

	private void StopSpinning()
	{
	}

	private void StartWithOutCoinsClicked()
	{
	}

	private void StopWithOutCoinsClicked()
	{
	}

	private void OnStartClick()
	{
	}

	private void SpinningStopped()
	{
	}

	private void ResetSpinnerScale()
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

	[IteratorStateMachine(typeof(_003CPointerDownAndHoldCoroutine_003Ed__54))]
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

	private void Close()
	{
	}

	private void SetWatchAdsButtonText(string text)
	{
	}

	private void SetButterflyState(bool state)
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

	private void StopTutorialHandCoroutine()
	{
	}

	[IteratorStateMachine(typeof(_003CTutorialHandCoroutine_003Ed__66))]
	private IEnumerator TutorialHandCoroutine()
	{
		return null;
	}

	private void LogUIInteractionEvent(string uiAction)
	{
	}
}
