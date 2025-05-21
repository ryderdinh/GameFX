using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.EventSystems;

public class BoosterDropObject : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
{
	[CompilerGenerated]
	private sealed class _003CShowDropBoosterTutorialCR_003Ed__43 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BoosterDropObject _003C_003E4__this;

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
		public _003CShowDropBoosterTutorialCR_003Ed__43(int _003C_003E1__state)
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
	private sealed class _003CDisappearTimeCR_003Ed__47 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BoosterDropObject _003C_003E4__this;

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
		public _003CDisappearTimeCR_003Ed__47(int _003C_003E1__state)
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
	private ButterflyRewardController _rewardController;

	[SerializeField]
	private GameObject _dropObject;

	[SerializeField]
	private GameObject[] _shadowObjects;

	[SerializeField]
	private GameObject[] _particles;

	[SerializeField]
	private WatchAdButton _watchAdButton;

	[SerializeField]
	private Material _timerFillImage;

	[SerializeField]
	private Transform _boosterContainerTransform;

	[SerializeField]
	private ParticleSystem _dustParticles;

	[SerializeField]
	protected Animator[] _animators;

	[SerializeField]
	private UserJourneySystem _userJourneySystem;

	private float _remainingTime;

	private Coroutine _disappearTimerCR;

	private Coroutine _dropTutorialTimerCR;

	private Action _executeBooster;

	private readonly WaitForSeconds _waitForOneSecond;

	private Boosters _booster;

	private float _dropObjectDisappearTime;

	private BoosterDropData _dropData;

	private Vector3 _initialScale;

	private Vector3 _initialPosition;

	private bool _canClickBooster;

	private bool _boosterClaimed;

	private Tweener _timerTween;

	protected Camera _WorldCamera;

	protected Camera _UICamera;

	protected static readonly int _OnBoardState;

	protected static readonly int _DroppingState;

	private static readonly int Arc2;

	public Transform BoosterContainerTransform => null;

	public virtual void Initialize(Boosters booster, float disappearTime)
	{
	}

	public virtual void DropBooster(BoosterDropData dropData)
	{
	}

	private void ResetTransforms()
	{
	}

	public void BoosterDropped()
	{
	}

	public void OnPointerDown(PointerEventData eventData)
	{
	}

	public void OnPointerUp(PointerEventData eventData)
	{
	}

	protected virtual void SetAnimatorToOnBoardState(bool state)
	{
	}

	protected virtual void AnimateObjectOnClaim()
	{
	}

	private void DuringSkipItAnimation()
	{
	}

	private void BoosterClaimed(bool result)
	{
	}

	private void SetDropObjectInteractableState(bool state)
	{
	}

	private void TutorialCompleted()
	{
	}

	private void ActiveDroppedState()
	{
	}

	[IteratorStateMachine(typeof(_003CShowDropBoosterTutorialCR_003Ed__43))]
	private IEnumerator ShowDropBoosterTutorialCR()
	{
		return null;
	}

	private void StopDropTutorialTimerCR()
	{
	}

	private void StartDisappearTimerCR()
	{
	}

	private void StopDisappearTimerCR()
	{
	}

	[IteratorStateMachine(typeof(_003CDisappearTimeCR_003Ed__47))]
	private IEnumerator DisappearTimeCR()
	{
		return null;
	}

	private void DisappearTimeCompleted()
	{
	}

	private void HideObjects()
	{
	}

	private void FreeSlotAndHideObjects()
	{
	}

	private void DisableDropObject()
	{
	}

	private void SetShadowObjectState(bool state)
	{
	}

	private void SetParticleObjectsState(bool state)
	{
	}

	private void SetWatchAdButtonState(bool state)
	{
	}

	private void SetDropObjectState(bool state)
	{
	}
}
