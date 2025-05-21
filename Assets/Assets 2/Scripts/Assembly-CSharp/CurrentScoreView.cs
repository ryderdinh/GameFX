using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using MSKit.UIView;

public class CurrentScoreView : BaseUIViewController<CurrentScoreViewRefs>
{
	[CompilerGenerated]
	private sealed class _003CTypeWriterEffect_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CurrentScoreView _003C_003E4__this;

		public string text;

		private string _003C_003E7__wrap1;

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
		public _003CTypeWriterEffect_003Ed__16(int _003C_003E1__state)
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

	private int _currentLevel;

	private int _lastLevel;

	private int _highestLevel;

	private int _lastHighestLevel;

	public bool CanUpdateScore;

	public float Duration;

	public override void RegisterEvents()
	{
	}

	public override void UnregisterEvents()
	{
	}

	public override void Show(object model = null)
	{
	}

	public override void Hide()
	{
	}

	private void ResetView()
	{
	}

	public override void InitializeTexts()
	{
	}

	public override void InitializeButtons()
	{
	}

	private void UpdateScoreOnEvent(float score)
	{
	}

	private void UpdateCurrentScore(int levelsToAdd, float baseDelay = 0f)
	{
	}

	private void MoveCurrentScore()
	{
	}

	[IteratorStateMachine(typeof(_003CTypeWriterEffect_003Ed__16))]
	private IEnumerator TypeWriterEffect(string text)
	{
		return null;
	}

	private void SetNormalScoreGradient()
	{
	}

	private void SetHighScoreGradient()
	{
	}

	private void UpdateScoreText(float value)
	{
	}
}
