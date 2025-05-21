using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using MS.Casual.Market;
using UnityEngine;

public abstract class BaseOfferController : IIApp, ISpecialOffer
{
	[CompilerGenerated]
	private sealed class _003CCooldownCR_003Ed__37 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BaseOfferController _003C_003E4__this;

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
		public _003CCooldownCR_003Ed__37(int _003C_003E1__state)
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
	private sealed class _003CTimeCalculator_003Ed__44 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BaseOfferController _003C_003E4__this;

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
		public _003CTimeCalculator_003Ed__44(int _003C_003E1__state)
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

	protected string OfferID;

	protected List<SpecialOffer> _specialOffers;

	protected GameConfig _gameConfig;

	protected RemoteAppConfig _remoteAppConfig;

	protected SpecialOfferItemData _currentSpecialOfferData;

	protected int _currentOfferIndex;

	private readonly WaitForSeconds _waitOneSec;

	private readonly MonoBehaviour _coroutineRunner;

	private Coroutine _timerRoutine;

	private Coroutine _cooldownTimerRoutine;

	protected bool _allOffersPurchased;

	private IAPHandler _iAPHandler;

	private SpecialOfferTimeController _timer;

	private OfferCooldownTimeController _cooldownTimer;

	private double _cooldownTime;

	protected bool _CooldownState;

	public SpecialOfferTimeController Timer => null;

	public SpecialOfferItemData OfferItemData => null;

	public bool CooldownState()
	{
		return false;
	}

	public SpecialOfferModel GetCurrentOfferModel()
	{
		return default(SpecialOfferModel);
	}

	public abstract void ShowOfferOnLaunch();

	public abstract void ShowOfferOnResume();

	public abstract void ShowFullScreenOffer(Action callBack = null);

	protected abstract void InitializeOffers();

	protected BaseOfferController(MonoBehaviour mono)
	{
	}

	protected void InitializeInApp()
	{
	}

	protected virtual void Initialize()
	{
	}

	protected abstract SpecialOfferItemData GetOfferAgainstIndex(int index);

	protected virtual void OfferClaimed(bool isRestore)
	{
	}

	protected virtual void OfferExpired()
	{
	}

	protected void StopCooldownTimerCR()
	{
	}

	private void UpdateCooldownState(bool state)
	{
	}

	protected virtual void LoadCooldownTimer()
	{
	}

	protected void LoadNewCooldownTimer()
	{
	}

	protected virtual void CooldownExpired()
	{
	}

	[IteratorStateMachine(typeof(_003CCooldownCR_003Ed__37))]
	private IEnumerator CooldownCR()
	{
		return null;
	}

	protected void StopTimerCoroutine()
	{
	}

	private int GetNextOfferIndex(bool isPurchased)
	{
		return 0;
	}

	void ISpecialOffer.PurchaseOffer()
	{
	}

	private void LoadOffer()
	{
	}

	protected virtual void LoadAvailableOffer()
	{
	}

	protected virtual void LoadNewOffer(bool isPurchased = false)
	{
	}

	[IteratorStateMachine(typeof(_003CTimeCalculator_003Ed__44))]
	private IEnumerator TimeCalculator()
	{
		return null;
	}

	void IIApp.PurchaseSuccessfull(bool isRestore)
	{
	}

	void IIApp.PurchaseFailed()
	{
	}
}
