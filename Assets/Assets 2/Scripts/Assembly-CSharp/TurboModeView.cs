using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TurboModeView : MonoBehaviour, ITurboMode
{
	[CompilerGenerated]
	private sealed class _003CTurboModeCtaCR_003Ed__44 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TurboModeView _003C_003E4__this;

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
		public _003CTurboModeCtaCR_003Ed__44(int _003C_003E1__state)
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
	private TurboModeSystem _turboMode;

	[SerializeField]
	private Transform _container;

	[SerializeField]
	[Header("Activated State")]
	private GameObject _activatedStateObject;

	[SerializeField]
	private Image _turboFillBar;

	[SerializeField]
	private Button _activeStateButton;

	[SerializeField]
	private TurboModeToggle _turboModeToggle;

	[SerializeField]
	[Header("Text Bubble")]
	private TextMeshProUGUI _remainingMovesText;

	[SerializeField]
	private RectTransform _bubbleContainer;

	[Header("Locked State")]
	[SerializeField]
	private GameObject _lockedStateObject;

	[SerializeField]
	private Button _lockedStateButton;

	[SerializeField]
	[Header("Deactivated State")]
	private ButtonPressed _buttonState;

	[SerializeField]
	private GameObject _deactivatedStateObject;

	[SerializeField]
	private WatchAdButton _watchAdButton;

	[SerializeField]
	private Button _freeTurboButton;

	[SerializeField]
	[Header("Affirmation Views")]
	private TurboModeActiveAffirmationView _activeAffirmation;

	[SerializeField]
	private TurboModeCompleteAffirmationView _completeAffirmation;

	[Header("Tutorial")]
	[SerializeField]
	private TurboModeTutorialView _turboTutorial;

	[SerializeField]
	private GameObject _blocker;

	private Vector3 _buttonDefaultPosition;

	private WaitForSeconds _ctaWaitForSeconds;

	private Coroutine _ctaRoutine;

	private bool _canShowCta;

	private DateTime _buttonShowTime;

	private bool _isTimeSet;

	public void Initialize()
	{
	}

	private void InitializeButtons()
	{
	}

	private void ActivateTurboMode(bool adWatched)
	{
	}

	private void RegisterEvents()
	{
	}

	private void SetCanShowCtaOnTraysWarning(bool state)
	{
	}

	private void ResetSpeechBubble()
	{
	}

	private void OnBubbleButtonPressed()
	{
	}

	public void Show()
	{
	}

	public void Hide()
	{
	}

	public void ForceHideView()
	{
	}

	public void TurboModeActivated()
	{
	}

	public void UpdateTurboModeUnlockedView()
	{
	}

	public void TurboModeDeactivated()
	{
	}

	public void UpdateTurboModeView(float duration = 0.35f)
	{
	}

	public void ShowTurboModeTutorial()
	{
	}

	private void MoveInView()
	{
	}

	private void MoveOutView()
	{
	}

	private void ForceMoveOutView()
	{
	}

	private void SetButtonState(TurboModeState state)
	{
	}

	private void SetLockedState(bool state)
	{
	}

	[IteratorStateMachine(typeof(_003CTurboModeCtaCR_003Ed__44))]
	private IEnumerator TurboModeCtaCR()
	{
		return null;
	}

	private void RestartTurboModeCtaRoutine()
	{
	}

	private void ShowTutorial()
	{
	}

	private void SetFreeTurboButtonState(bool state)
	{
	}

	private void ActiveTurboModeForFree()
	{
	}

	private void HideTutorial()
	{
	}

	private void PlayButtonImpact()
	{
	}
}
