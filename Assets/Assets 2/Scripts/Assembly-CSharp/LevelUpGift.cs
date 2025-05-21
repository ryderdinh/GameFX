using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Analytics;
using UnityEngine;
using UnityEngine.EventSystems;

public class LevelUpGift : MonoBehaviour, IPointerDownHandler, IEventSystemHandler
{
	[CompilerGenerated]
	private sealed class _003CAnimationCoroutine_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LevelUpGift _003C_003E4__this;

		private WaitForSeconds _003Cwait_003E5__2;

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
		public _003CAnimationCoroutine_003Ed__23(int _003C_003E1__state)
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
	private AnalyticsSystem _analyticsSystem;

	[SerializeField]
	private Animator _giftAnimator;

	[SerializeField]
	private BoxCollider _boxCollider;

	[SerializeField]
	private GameObject _boxBase;

	[SerializeField]
	private GameObject _shineParticleObject;

	[SerializeField]
	private GameObject _glowParticleObject;

	[SerializeField]
	private ParticleSystem _dropParticles;

	[SerializeField]
	private Material _material;

	[SerializeField]
	private GiftSpawnerSystem _giftSpawnerSystem;

	private ILevelUpGift _levelUpGiftHandler;

	private Coroutine _animationCoroutine;

	private Vector3 _initialRotation;

	private int _idleAnimationDelay;

	private bool _isOpened;

	private bool _canOpenGift;

	public void Initialize(ILevelUpGift levelUpGift)
	{
	}

	private void RegisterEvents()
	{
	}

	private void SetGiftState(bool state)
	{
	}

	public void DropGift(Vector3 startPosition)
	{
	}

	public void SetGiftBoxTexture()
	{
	}

	public void DropComplete()
	{
	}

	private void StartAnimationCR()
	{
	}

	private void StopAnimationCR()
	{
	}

	[IteratorStateMachine(typeof(_003CAnimationCoroutine_003Ed__23))]
	private IEnumerator AnimationCoroutine()
	{
		return null;
	}

	private void PlayIdleAnimation()
	{
	}

	void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
	{
	}

	public void Reset()
	{
	}
}
