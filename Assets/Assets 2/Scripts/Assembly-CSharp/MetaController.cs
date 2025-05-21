using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MetaController : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CUpdateWorldProgressStateCoroutine_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MetaController _003C_003E4__this;

		public int index;

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
		public _003CUpdateWorldProgressStateCoroutine_003Ed__21(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CWorldComplete_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float delay;

		public MetaController _003C_003E4__this;

		private int _003Cindex_003E5__2;

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
		public _003CWorldComplete_003Ed__29(int _003C_003E1__state)
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
	private Transform[] _shopParent;

	[SerializeField]
	private Transform _platformTransform;

	[SerializeField]
	private Transform _skyBoxTransform;

	[SerializeField]
	private MetaSystem _metaSystem;

	[SerializeField]
	private AnimationCurve _scrollEase;

	private float _xShopOffset;

	private IMetaMenuView _metaViewHandler;

	private WorldRotationController _gyroController;

	private Dictionary<int, World> _shopsDictionary;

	private Dictionary<int, GameObject> _constructionSitesDictionary;

	public int MetaCount => 0;

	public int MetaInProgressID => 0;

	public bool AllWorldsUnlocked => false;

	public string GetMetaWorldName(int index)
	{
		return null;
	}

	public void Initialize(IMetaMenuView metaViewHandler)
	{
	}

	public void Show(int index)
	{
	}

	public void RotateWorld(int index)
	{
	}

	private void WorldUnlocked()
	{
	}

	[IteratorStateMachine(typeof(_003CUpdateWorldProgressStateCoroutine_003Ed__21))]
	private IEnumerator UpdateWorldProgressStateCoroutine(int index)
	{
		return null;
	}

	public void ForceRotateMeta(int index)
	{
	}

	private void SpawnMetaItem(int index)
	{
	}

	private void SpawnShop(int index)
	{
	}

	private void SpawnConstructionSite(int index)
	{
	}

	public void CatFollow(int index, bool isInitialization = false)
	{
	}

	private void ForceUpdateMeta()
	{
	}

	private void RemoveConstructionSite(int index)
	{
	}

	[IteratorStateMachine(typeof(_003CWorldComplete_003Ed__29))]
	private IEnumerator WorldComplete(float delay)
	{
		return null;
	}
}
