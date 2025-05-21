using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using MSKit.Loading;
using UnityEngine;

public class PreWarming : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CPreWarmCR_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PreWarming _003C_003E4__this;

		private WaitForSeconds _003Cwait_003E5__2;

		private int _003Ci_003E5__3;

		private int _003Ccount_003E5__4;

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
		public _003CPreWarmCR_003Ed__5(int _003C_003E1__state)
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

	public List<Material> AllMaterials;

	[SerializeField]
	private MeshRenderer _meshForPreWarming;

	[SerializeField]
	private LoadingController _loadingController;

	[SerializeField]
	private LoadingViewController _loadingViewController;

	[SerializeField]
	private GameObject _particles;

	[IteratorStateMachine(typeof(_003CPreWarmCR_003Ed__5))]
	private IEnumerator PreWarmCR()
	{
		return null;
	}

	public void StartPreWarming()
	{
	}
}
