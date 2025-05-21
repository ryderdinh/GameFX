using MSKit.Game;
using UnityEngine;

namespace MSKit
{
	public class ApplicationController : MonoBehaviour
	{
		private bool _isGameLoaded;

		public GameController GameController { private get; set; }

		private void Start()
		{
		}

		private void OnApplicationQuit()
		{
		}

		private void OnApplicationPause(bool pause)
		{
		}

		private void AppInBackGroundState()
		{
		}

		private void ResumeApplication()
		{
		}
	}
}
