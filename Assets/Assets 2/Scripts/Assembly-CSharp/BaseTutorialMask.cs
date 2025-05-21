using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BaseTutorialMask : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CTutorialHandCoroutine_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BaseTutorialMask _003C_003E4__this;

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
		public _003CTutorialHandCoroutine_003Ed__16(int _003C_003E1__state)
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
	private RectTransform BackgroundSoftMaskTrasform;

	[SerializeField]
	private Transform BackgroundSoftMaskFrameTransform;

	[SerializeField]
	private GameObject Container;

	[SerializeField]
	private Transform HandsContainer;

	[SerializeField]
	private RectTransform HandsContainerRect;

	[SerializeField]
	private GameObject HandUp;

	[SerializeField]
	private GameObject HandDown;

	private Coroutine _handCoroutine;

	protected bool _IsTutorialActive;

	protected Vector3 MaskPosition => default(Vector3);

	protected Vector3 MaskAnchoredPosition => default(Vector3);

	public void ShowTutorial(Vector3 butterflyPosition, float duration = 1f, bool showHand = false, bool calculateScreenPoint = false, float scale = 1f, float handPosition = 1f, Vector3 handOffset = default(Vector3))
	{
	}

	public void ShowTutorial(Vector3 scale, float duration = 0.5f, bool showHand = true)
	{
	}

	public void HideTutorial()
	{
	}

	[IteratorStateMachine(typeof(_003CTutorialHandCoroutine_003Ed__16))]
	private IEnumerator TutorialHandCoroutine()
	{
		return null;
	}

	public void TutorialCompleted()
	{
	}

	private void StopTutorialHandCR()
	{
	}
}
