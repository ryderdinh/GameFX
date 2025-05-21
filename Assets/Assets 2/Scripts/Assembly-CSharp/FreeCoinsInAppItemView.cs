using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DB;
using MS.Casual.Market;
using UnityEngine;

public class FreeCoinsInAppItemView : BaseMarketItemView
{
	[CompilerGenerated]
	private sealed class _003CStartTimer_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FreeCoinsInAppItemView _003C_003E4__this;

		private float _003CremainingTime_003E5__2;

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
		public _003CStartTimer_003Ed__7(int _003C_003E1__state)
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
	private CashObject _cashObject;

	[SerializeField]
	private DBLong _dbLastClaimTime;

	private float _rewardInterval;

	private DateTime _lastClaimTime;

	protected override void PreInitialize()
	{
	}

	protected override void Initialize()
	{
	}

	protected override void UpdateData()
	{
	}

	[IteratorStateMachine(typeof(_003CStartTimer_003Ed__7))]
	private IEnumerator StartTimer()
	{
		return null;
	}

	protected override void BuyItem()
	{
	}

	private float GetRemainingTime()
	{
		return 0f;
	}
}
