using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Nakama;
using UnityEngine;

namespace Core.Server
{
	[CreateAssetMenu(fileName = "NakamaSystem", menuName = "Nakama/NakamaSystem")]
	public class NakamaServer : ScriptableObject
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CGetSessionAsync_003Ed__31 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<ISession> _003C_003Et__builder;

			public NakamaServer _003C_003E4__this;

			private TaskAwaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CUpdateUserProfile_003Ed__32 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public NakamaServer _003C_003E4__this;

			public string username;

			public string avatarUrl;

			private TaskAwaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CAuthenticateWithDevice_003Ed__36 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public NakamaServer _003C_003E4__this;

			private TaskAwaiter<ISession> _003C_003Eu__1;

			private int _003C_003E7__wrap1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CSetupAccount_003Ed__37 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public NakamaServer _003C_003E4__this;

			private TaskAwaiter<IApiAccount> _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CUpdateAccount_003Ed__38 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public NakamaServer _003C_003E4__this;

			public string displayName;

			public string avatarUrl;

			private TaskAwaiter<ISession> _003C_003Eu__1;

			private TaskAwaiter _003C_003Eu__2;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		private readonly bool ENABLE_LOGGING;

		private static readonly string URL;

		private static readonly string SCHEME;

		private static readonly string SERVER_KEY;

		private static readonly string DEVICE_ID_KEY;

		private static readonly string AUTH_TOKEN_KEY;

		private static readonly string REFRESH_TOKEN_KEY;

		private const int PORT = 443;

		private const int TIMEOUT = 3;

		[NonSerialized]
		private Client _client;

		[NonSerialized]
		private NakamaLogger _logger;

		[NonSerialized]
		private ISession _session;

		[NonSerialized]
		private IApiAccount _account;

		[NonSerialized]
		private string _userId;

		[NonSerialized]
		private string _userName;

		[NonSerialized]
		private CancellationToken _canceller;

		[NonSerialized]
		private NakamaCoroutineHandler _coroutineHandler;

		internal string UserID => null;

		internal string UserName => null;

		internal NakamaLogger Logger => null;

		internal NakamaCoroutineHandler CoroutineHandler => null;

		internal CancellationToken Canceller => default(CancellationToken);

		internal Client Client => null;

		private bool IsSessionValid => false;

		private string DeviceId => null;

		[AsyncStateMachine(typeof(_003CGetSessionAsync_003Ed__31))]
		internal Task<ISession> GetSessionAsync()
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CUpdateUserProfile_003Ed__32))]
		internal Task UpdateUserProfile(string username, string avatarUrl)
		{
			return null;
		}

		private void RetryListener(int count, Retry retry)
		{
		}

		[AsyncStateMachine(typeof(_003CAuthenticateWithDevice_003Ed__36))]
		private Task AuthenticateWithDevice()
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CSetupAccount_003Ed__37))]
		private Task SetupAccount()
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CUpdateAccount_003Ed__38))]
		private Task UpdateAccount(string displayName, string avatarUrl)
		{
			return null;
		}
	}
}
