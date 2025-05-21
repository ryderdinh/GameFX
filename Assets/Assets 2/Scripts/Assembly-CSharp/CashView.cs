using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using MSKit.ResourcePool;
using MSKit.UIView;
using UnityEngine;

public class CashView : BaseUIViewController<CashViewRefs>
{
	[CompilerGenerated]
	private sealed class _003CReparentCoroutine_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CashView _003C_003E4__this;

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
		public _003CReparentCoroutine_003Ed__30(int _003C_003E1__state)
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
	private bool _isMarketCashView;

	[SerializeField]
	private bool _isMainMenuCashView;

	[SerializeField]
	private bool _isCashViewPresentInMainMenu;

	[SerializeField]
	private IAPOfferContext _iAPOfferContext;

	private int _cashAmount;

	private Sequence _coinSequence;

	private Vector3 _initialScale;

	private CashViewConfig _cashConfigs;

	private Pool<Coin> _coinPool;

	private Transform _defaultContainer;

	private Coroutine reparentCoroutine;

	private WaitForSeconds _reparentWait;

	private Camera _uiCamera;

	public override void Initialize()
	{
	}

	public void CashViewPresentInMainMenu(bool isCashViewPresentInMainMenu)
	{
	}

	public override void InitializeTexts()
	{
	}

	public override void InitializeButtons()
	{
	}

	public override void RegisterEvents()
	{
	}

	public override void Show(object model = null)
	{
	}

	public void SetupCash()
	{
	}

	public override void UnregisterEvents()
	{
	}

	private void ForceUpdateCash(int cash)
	{
	}

	private void UpdateCash(int cash)
	{
	}

	private void PlayCoinAnimation(CollectablesData data)
	{
	}

	private void UpdateMarketCashView(CollectablesData data)
	{
	}

	private void UpdateMainMenuCashView(CollectablesData data)
	{
	}

	private void UpdateGameplayCashView(CollectablesData data)
	{
	}

	public override void Hide()
	{
	}

	private void UpdateCashWithCoinAnimation(CollectablesData data)
	{
	}

	private void ReparentCoins()
	{
	}

	[IteratorStateMachine(typeof(_003CReparentCoroutine_003Ed__30))]
	private IEnumerator ReparentCoroutine()
	{
		return null;
	}

	private Vector2 GetScreenPosition(Vector3 pos)
	{
		return default(Vector2);
	}

	private void InitializeCoins()
	{
	}

	private void OnClickCoinsButton()
	{
	}
}
