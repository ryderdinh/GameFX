using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace MSKit.Gameplay
{
	public class GamePlayController : MonoBehaviour
	{
		private readonly Dictionary<string, BaseGameController> _bindedGames;

		private BaseGameController _currentGameController;

		private GameType _gameType;

		public void PreLoadGame(GameType gameType)
		{
		}

		public void LoadGame(GameType gameType)
		{
		}

		public void PostLoadGame()
		{
		}

		public void StartGame()
		{
		}

		public void CompleteGame()
		{
		}

		public void FailGame()
		{
		}

		public void UnLoadGame()
		{
		}

		private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
		{
		}
	}
}
