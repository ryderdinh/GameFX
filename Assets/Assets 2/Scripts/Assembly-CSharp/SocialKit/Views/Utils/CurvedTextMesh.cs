using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

namespace SocialKit.Views.Utils
{
	public class CurvedTextMesh : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CWarpText_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public CurvedTextMesh _003C_003E4__this;

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
			public _003CWarpText_003Ed__8(int _003C_003E1__state)
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

		public AnimationCurve VertexCurve;

		public float CurveScale;

		private TMP_Text _textComponent;

		private Coroutine _animationCoroutine;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private AnimationCurve CopyAnimationCurve(AnimationCurve curve)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CWarpText_003Ed__8))]
		private IEnumerator WarpText()
		{
			return null;
		}
	}
}
