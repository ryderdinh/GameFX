using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class FlowerRotationImpact
{
	[CompilerGenerated]
	private sealed class _003CObjectRotate_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FlowerRotationImpact _003C_003E4__this;

		public bool horizontal;

		private Vector3 _003CcurrentRotation_003E5__2;

		private float _003CstartingAngle_003E5__3;

		private float _003CrotationAngle_003E5__4;

		private float _003Ctime_003E5__5;

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
		public _003CObjectRotate_003Ed__10(int _003C_003E1__state)
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

	private float _intialRotationAngle;

	private float _rotationAngle;

	private float _rotationSpeed;

	private float _rotationSlowDownSpeed;

	private Transform _transformToRotate;

	private Transform _rotator;

	private MonoBehaviour _crRunner;

	private Coroutine _rotationCR;

	public FlowerRotationImpact(Transform transform, MonoBehaviour mono, Transform rotator)
	{
	}

	public void ApplyWindRotation(bool horizontal)
	{
	}

	[IteratorStateMachine(typeof(_003CObjectRotate_003Ed__10))]
	private IEnumerator ObjectRotate(bool horizontal)
	{
		return null;
	}
}
