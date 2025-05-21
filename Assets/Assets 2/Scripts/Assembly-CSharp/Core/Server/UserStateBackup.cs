using System;
using System.Collections.Generic;
using DB;
using UnityEngine;

namespace Core.Server
{
	[CreateAssetMenu(fileName = "UserStateBackup", menuName = "Nakama/UserStateBackup")]
	public class UserStateBackup : ScriptableObject
	{
		[SerializeField]
		private UserProgress _userProgress;

		[SerializeField]
		private ScoreSystem _scoreSystem;

		[SerializeField]
		private DBBool _forceSyncFromServer;

		private Action _callBackOnUserStateLoading;

		private void OnEnable()
		{
		}

		private void InitializeEvents()
		{
		}

		public void BackUpUserState()
		{
		}

		public void LoadUserState(Action callback)
		{
		}

		private void UpdateUserState(Dictionary<string, object> state)
		{
		}

		private void GetUserScoreOFromCloud(Action<int> callBack)
		{
		}
	}
}
