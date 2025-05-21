using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BoostersTutorialViewController : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CTutorialHandCoroutine_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BoostersTutorialViewController _003C_003E4__this;

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
		public _003CTutorialHandCoroutine_003Ed__13(int _003C_003E1__state)
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
	private GameObject Container;

	[SerializeField]
	private Transform HandsContainer;

	[SerializeField]
	private GameObject HandUp;

	[SerializeField]
	private GameObject HandDown;

	private Coroutine _handCoroutine;

	private Camera _mainCamera;

	private bool _isMainCameraNull;

	private Camera _camera;

	private void Start()
	{
	}

	public void Initialize()
	{
	}

	protected virtual void InitializeEvents()
	{
	}

	protected void OnShowBoostersTutorialEvent(BoostersTutorialDataModel boostersTutorialDataModel)
	{
	}

	protected virtual void BoostersTapTutorial(Vector3 screenPosition)
	{
	}

	[IteratorStateMachine(typeof(_003CTutorialHandCoroutine_003Ed__13))]
	private IEnumerator TutorialHandCoroutine()
	{
		return null;
	}

	protected void OnBoostersTutorialCompletedEvent()
	{
	}
}
