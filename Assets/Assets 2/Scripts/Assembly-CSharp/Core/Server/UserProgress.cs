using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using UnityEngine;

namespace Core.Server
{
	[CreateAssetMenu(fileName = "UserProgress", menuName = "Nakama/UserProgress")]
	public class UserProgress : ScriptableObject
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass7_0
		{
			public Task<string> dataTask;

			internal bool _003CGetUserProgressAsync_003Eb__0()
			{
				return false;
			}
		}

		[CompilerGenerated]
		private sealed class _003CGetUserProgressAsync_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public UserProgress _003C_003E4__this;

			private _003C_003Ec__DisplayClass7_0 _003C_003E8__1;

			public Action<Dictionary<string, object>> action;

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
			public _003CGetUserProgressAsync_003Ed__7(int _003C_003E1__state)
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
		private sealed class _003C_003Ec__DisplayClass8_0
		{
			public Task dataTask;

			internal bool _003CSaveUserProgressAsync_003Eb__0()
			{
				return false;
			}
		}

		[CompilerGenerated]
		private sealed class _003CSaveUserProgressAsync_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Dictionary<string, object> data;

			public UserProgress _003C_003E4__this;

			public Action<bool> action;

			private _003C_003Ec__DisplayClass8_0 _003C_003E8__1;

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
			public _003CSaveUserProgressAsync_003Ed__8(int _003C_003E1__state)
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
		private sealed class _003C_003Ec__DisplayClass9_0
		{
			public Task dataTask;

			internal bool _003CUpdateUserProfileAsync_003Eb__0()
			{
				return false;
			}
		}

		[CompilerGenerated]
		private sealed class _003CUpdateUserProfileAsync_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public UserProgress _003C_003E4__this;

			public string username;

			public string avatarUrl;

			public Action<bool> action;

			private _003C_003Ec__DisplayClass9_0 _003C_003E8__1;

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
			public _003CUpdateUserProfileAsync_003Ed__9(int _003C_003E1__state)
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
		private NakamaUserProgress NakamaUserProgress;

		[SerializeField]
		private NakamaServer NakamaServer;

		public void GetUserProgress(Action<Dictionary<string, object>> action)
		{
		}

		public void SaveUserProgress(Dictionary<string, object> data)
		{
		}

		public void SaveUserProgress(Dictionary<string, object> data, Action<bool> action)
		{
		}

		public void UpdateUserProfile(string username, string avatarUrl, Action<bool> action)
		{
		}

		public void DeleteUserProgress()
		{
		}

		[IteratorStateMachine(typeof(_003CGetUserProgressAsync_003Ed__7))]
		private IEnumerator GetUserProgressAsync(Action<Dictionary<string, object>> action)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CSaveUserProgressAsync_003Ed__8))]
		private IEnumerator SaveUserProgressAsync(Dictionary<string, object> data, Action<bool> action)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CUpdateUserProfileAsync_003Ed__9))]
		private IEnumerator UpdateUserProfileAsync(string username, string avatarUrl, Action<bool> action)
		{
			return null;
		}
	}
}
