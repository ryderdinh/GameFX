using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DB;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DailyGiftInAppItemView : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CDisplayTimer_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DailyGiftInAppItemView _003C_003E4__this;

		private int _003CtimeLeft_003E5__2;

		private WaitForSeconds _003Cwait_003E5__3;

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
		public _003CDisplayTimer_003Ed__29(int _003C_003E1__state)
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
	private DBLong _dbStartingTime;

	[SerializeField]
	private TextMeshProUGUI _priceText;

	[SerializeField]
	private TextMeshProUGUI _priceTextDepth;

	[SerializeField]
	private TextMeshProUGUI _coinsText;

	[SerializeField]
	private TextMeshProUGUI _timerText;

	[SerializeField]
	private Button _buyButton;

	[SerializeField]
	private GameObject _container;

	[SerializeField]
	private GameObject _availableState;

	[SerializeField]
	private GameObject _unavailableState;

	[SerializeField]
	private MarketDailyGiftData _marketDailyGiftData;

	private DateTime _startTime;

	private Camera _uiCamera;

	private Coroutine _timerCR;

	public Transform DailyGiftTransform => null;

	private void InitializeTexts()
	{
	}

	private void InitializeButtons()
	{
	}

	private void InitializeEvents()
	{
	}

	private void BuyItem()
	{
	}

	protected void PlayButtonImpact()
	{
	}

	public void Initialize()
	{
	}

	public void Show()
	{
	}

	public void Hide()
	{
	}

	private bool IsDailyFreeGiftAvailable()
	{
		return false;
	}

	private void CheckForGiftState()
	{
	}

	private void MoveToRewardState()
	{
	}

	private void StartTimerCR()
	{
	}

	private void StopTimerCR()
	{
	}

	private void StartTimer()
	{
	}

	[IteratorStateMachine(typeof(_003CDisplayTimer_003Ed__29))]
	private IEnumerator DisplayTimer()
	{
		return null;
	}

	private void UpdateView(bool isAvailable)
	{
	}
}
