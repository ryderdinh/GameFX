using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using MSKit.UIView;
using TMPro;
using UnityEngine;

public class EventIntroView : BaseUIViewController<EventIntroViewRefs>
{
	[CompilerGenerated]
	private sealed class _003CType_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string s;

		public TextMeshProUGUI textMesh;

		public EventIntroView _003C_003E4__this;

		private char[] _003C_003E7__wrap1;

		private int _003C_003E7__wrap2;

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
		public _003CType_003Ed__20(int _003C_003E1__state)
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

	private ViewAnimationController _viewAnim;

	private Transform _closeButtonTransform;

	private Vector3 _eventHeaderDefaultScale;

	private Vector3 _closeButtonDefaultScale;

	private Vector3 _headerDefaultRotation;

	private string _bloomPassText;

	private string _missionText;

	private string _bundleOfferText;

	private float _offset;

	private WaitForSeconds _typeSpeed;

	private Sequence _introSequence;

	private Sequence _headerSequence;

	public override void Initialize()
	{
	}

	public override void InitializeButtons()
	{
	}

	public override void InitializeTexts()
	{
	}

	public override void RegisterEvents()
	{
	}

	public override void UnregisterEvents()
	{
	}

	public override void Show(object model = null)
	{
	}

	private void Reset()
	{
	}

	private void PlayEventIntroSequence()
	{
	}

	[IteratorStateMachine(typeof(_003CType_003Ed__20))]
	private IEnumerator Type(string s, TextMeshProUGUI textMesh)
	{
		return null;
	}

	private void CloseButtonClicked()
	{
	}

	private void Update()
	{
	}
}
