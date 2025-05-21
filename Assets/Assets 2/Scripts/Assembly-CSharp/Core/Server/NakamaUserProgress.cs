using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Nakama;
using UnityEngine;

namespace Core.Server
{
	[CreateAssetMenu(fileName = "NakamaUserProgress", menuName = "Nakama/NakamaUserProgress")]
	public class NakamaUserProgress : ScriptableObject
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CSaveProgress_003Ed__3 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public NakamaUserProgress _003C_003E4__this;

			public string json;

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
		private struct _003CGetProgress_003Ed__4 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

			public NakamaUserProgress _003C_003E4__this;

			private TaskAwaiter<IApiStorageObjects> _003C_003Eu__1;

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
		private struct _003CWriteStorageObject_003Ed__5 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public string collection;

			public string key;

			public string value;

			public NakamaUserProgress _003C_003E4__this;

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
		private struct _003CWriteStorageObject_003Ed__6 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public NakamaUserProgress _003C_003E4__this;

			public WriteStorageObject storageObject;

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
		private struct _003CWriteStorageObjects_003Ed__7 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public NakamaUserProgress _003C_003E4__this;

			public WriteStorageObject[] storageObjects;

			private TaskAwaiter<ISession> _003C_003Eu__1;

			private TaskAwaiter<IApiStorageObjectAcks> _003C_003Eu__2;

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
		private struct _003CReadStorageObject_003Ed__8 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<IApiStorageObjects> _003C_003Et__builder;

			public NakamaUserProgress _003C_003E4__this;

			public string collection;

			public string key;

			private TaskAwaiter<ISession> _003C_003Eu__1;

			private TaskAwaiter<IApiStorageObjects> _003C_003Eu__2;

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
		private struct _003CReadStorageObject_003Ed__9 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<IApiStorageObjects> _003C_003Et__builder;

			public NakamaUserProgress _003C_003E4__this;

			public IApiReadStorageObjectId apiReadStorageObjectId;

			private TaskAwaiter<IApiStorageObjects> _003C_003Eu__1;

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
		private struct _003CReadStorageObjects_003Ed__10 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<IApiStorageObjects> _003C_003Et__builder;

			public NakamaUserProgress _003C_003E4__this;

			public IApiReadStorageObjectId[] apiReadStorageObjectIds;

			private TaskAwaiter<ISession> _003C_003Eu__1;

			private TaskAwaiter<IApiStorageObjects> _003C_003Eu__2;

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

		private static readonly string USERSTATE_SAVE_COLLECTION_KEY;

		private static readonly string USERSTATE_SAVE_KEY;

		[SerializeField]
		private NakamaServer NakamaServer;

		[AsyncStateMachine(typeof(_003CSaveProgress_003Ed__3))]
		public Task SaveProgress(string json)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CGetProgress_003Ed__4))]
		public Task<string> GetProgress()
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CWriteStorageObject_003Ed__5))]
		private Task WriteStorageObject(string collection, string key, string value)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CWriteStorageObject_003Ed__6))]
		private Task WriteStorageObject(WriteStorageObject storageObject)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CWriteStorageObjects_003Ed__7))]
		private Task WriteStorageObjects(WriteStorageObject[] storageObjects)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CReadStorageObject_003Ed__8))]
		private Task<IApiStorageObjects> ReadStorageObject(string collection, string key)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CReadStorageObject_003Ed__9))]
		private Task<IApiStorageObjects> ReadStorageObject(IApiReadStorageObjectId apiReadStorageObjectId)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CReadStorageObjects_003Ed__10))]
		private Task<IApiStorageObjects> ReadStorageObjects(IApiReadStorageObjectId[] apiReadStorageObjectIds)
		{
			return null;
		}
	}
}
