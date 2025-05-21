using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DB;
using UnityEngine;

public class RowSortOnGrid : BaseGridBooster
{
	[CompilerGenerated]
	private sealed class _003CMovementAnimationCR_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public List<MovementData> moves;

		public List<Slot> slots;

		public RowSortOnGrid _003C_003E4__this;

		private List<Slot> _003Clist_003E5__2;

		private List<int> _003CslotsFullList_003E5__3;

		private List<Flower> _003Cpetals_003E5__4;

		private ProgressionSystem _003Cprogression_003E5__5;

		private int _003Cvalue_003E5__6;

		private WaitForSeconds _003CcomboWait_003E5__7;

		private int _003CcomboIndex_003E5__8;

		private int _003Ci_003E5__9;

		private int _003CbunchedMovesCount_003E5__10;

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
		public _003CMovementAnimationCR_003Ed__4(int _003C_003E1__state)
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

	private MonoBehaviour _coroutineRunner;

	public RowSortOnGrid(MonoBehaviour mono, IGridBooster gridBooster)
		: base(null)
	{
	}

	public void ApplyBooster(Slot slot, List<Slot> slots, int columns, ArrayArrayInt slotsCurrentState)
	{
	}

	private void MovePetals(List<Slot> slots, List<MovementData> moves)
	{
	}

	[IteratorStateMachine(typeof(_003CMovementAnimationCR_003Ed__4))]
	private IEnumerator MovementAnimationCR(List<Slot> slots, List<MovementData> moves)
	{
		return null;
	}

	private bool IsActingAsBridge(int i, int index, List<MovementData> moves)
	{
		return false;
	}

	private void ApplyForce(Flower cake)
	{
	}

	private void RemoveForce(List<Flower> cakes)
	{
	}
}
