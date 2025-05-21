using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using MSKit.Loading;
using UnityEngine;

public class LogoManager : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CPlaySecondLogoAnimation_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LogoManager _003C_003E4__this;

		private float _003CsecondLogoCurrentDuration_003E5__2;

		private Color _003CtargetColor_003E5__3;

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
		public _003CPlaySecondLogoAnimation_003Ed__7(int _003C_003E1__state)
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

	public int nextSceneBuildIndex;

	public float secondLogoLength;

	public SpriteRenderer secondLogoImage;

	public AnimationCurve logoAlphaCurve;

	public bool useSecondLogo;

	[SerializeField]
	private LoadingController _loadingController;

	[SerializeField]
	private PreWarming _preWarming;

	[IteratorStateMachine(typeof(_003CPlaySecondLogoAnimation_003Ed__7))]
	public IEnumerator PlaySecondLogoAnimation()
	{
		return null;
	}

	public void StartSecondLogo()
	{
	}
}
