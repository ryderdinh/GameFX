using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Core.Server;
using UnityEngine;

namespace MSKit.Loading
{
	public class LoadingController : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CLoadScene_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public LoadingController _003C_003E4__this;

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
			public _003CLoadScene_003Ed__10(int _003C_003E1__state)
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
		protected LoadingRefs _LoadingRefs;

		[SerializeField]
		private UserStateBackup _userStateBackup;

		[SerializeField]
		private UserJourneySystem _userJourneySystem;

		private bool _preWarmingCompleted;

		private bool _splashCompleted;

		private bool _userProgressLoaded;

		private AsyncOperation async;

		public void PreWarmingCompleted()
		{
		}

		public void SplashCompleted()
		{
		}

		private void Awake()
		{
		}

		[IteratorStateMachine(typeof(_003CLoadScene_003Ed__10))]
		private IEnumerator LoadScene()
		{
			return null;
		}

		private void LoadingComplete()
		{
		}

		private void LoadServer()
		{
		}

		private void ServerLoaded()
		{
		}
	}
}
