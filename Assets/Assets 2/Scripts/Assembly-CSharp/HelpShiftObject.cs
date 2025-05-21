using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Core.Server;
using Helpshift;
using LionStudios.Suite;
using UnityEngine;

[CreateAssetMenu(fileName = "HelpShiftModule", menuName = "Support/HelpShift Support Module")]
public class HelpShiftObject : ScriptableObject
{
	[CompilerGenerated]
	private sealed class _003CLoginUser_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HelpShiftObject _003C_003E4__this;

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
		public _003CLoginUser_003Ed__10(int _003C_003E1__state)
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
	private NakamaServer _nakamaServer;

	[SerializeField]
	private UserJourneySystem _userJourneySystem;

	private const string DOMAIN_NAME = "algames.helpshift.com";

	private const string ANDROID_ID = "algames_platform_20240203011101270-ab3c5aff49a5cf9";

	private const string IOS_ID = "algames_platform_20240203011101238-a80cc0473360a11";

	[NonSerialized]
	private HelpshiftSdk _helpshiftSDK;

	public void Initialise()
	{
	}

	public void UpdateUnreadMsgCount()
	{
	}

	public void ShowConversation()
	{
	}

	public void ShowFAQs()
	{
	}

	[IteratorStateMachine(typeof(_003CLoginUser_003Ed__10))]
	public IEnumerator LoginUser()
	{
		return null;
	}

	public void Logout()
	{
	}

	private Dictionary<string, object> GetInstallConfig()
	{
		return null;
	}

	private Dictionary<string, object> GetMetaData()
	{
		return null;
	}

	private Dictionary<string, object> GetCustomIssueFields()
	{
		return null;
	}

	private double GetDaysSinceInstalled()
	{
		return 0.0;
	}

	private Dictionary<string, string> GetUserDetails()
	{
		return null;
	}

	private IDictionary<string, PackageUtility.PackageInfo> GetPackageCollectionSnapshot()
	{
		return null;
	}
}
