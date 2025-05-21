using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PassiveBooster
{
	[CompilerGenerated]
	private sealed class _003CBoosterTimerCo_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PassiveBooster _003C_003E4__this;

		private WaitForSeconds _003Cwait_003E5__2;

		private DateTime _003CexpireTime_003E5__3;

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
		public _003CBoosterTimerCo_003Ed__17(int _003C_003E1__state)
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

	private PassiveBoosterData _data;

	private List<Item> _flowers;

	private MonoBehaviour _mono;

	private IPassiveBooster _passiveBoosterHandler;

	private Coroutine _coroutine;

	public PassiveBoosterType PassiveBoosterType => default(PassiveBoosterType);

	public PassiveBoosterCategory PassiveBoosterCategory => default(PassiveBoosterCategory);

	public long ExpireTime => 0L;

	public PassiveBoosterData Data => default(PassiveBoosterData);

	public PassiveBooster(PassiveBoosterData data, List<Item> flowers, MonoBehaviour mono, IPassiveBooster handler)
	{
	}

	public void AddPassiveBooster()
	{
	}

	public void HaltPassiveBooster()
	{
	}

	public void ResumePassiveBooster()
	{
	}

	[IteratorStateMachine(typeof(_003CBoosterTimerCo_003Ed__17))]
	private IEnumerator BoosterTimerCo()
	{
		return null;
	}

	private void StopScoreCoroutine()
	{
	}

	public void AddTime(int additionalTime)
	{
	}

	public void UpdateBonus()
	{
	}

	private void AddBonus()
	{
	}
}
