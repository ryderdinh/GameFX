using Analytics;
using DB;
using MS.Casual.Market;
using MSKit.Gameplay;
using MSKit.UIView;
using UnityEngine;

namespace MSKit.Game
{
	public class GameController : MonoBehaviour, IGameBaseState
	{
		[SerializeField]
		private DBBool _isNewGameStarted;

		[SerializeField]
		private Bool _isTutorialActive;

		[SerializeField]
		private UserJourneySystem _userJourneySystem;

		[SerializeField]
		private AnalyticsSystem _analyticsSystem;

		[SerializeField]
		private MetaWorldConfig _metaWorldConfig;

		[SerializeField]
		private PowerUpsSystem _powerUpsSystem;

		[SerializeField]
		private ReviveSystem _reviveSystem;

		[SerializeField]
		private LevelSystem _levelSystem;

		[SerializeField]
		private DailyLoginController _dailyLoginController;

		[SerializeField]
		private ContextualOffersObject _offersController;

		private LevelController _levelController;

		private MarketController _marketController;

		private bool _isUpdatedVersion;

		private bool _isLevelFail;

		private bool _isLoadingMenu;

		public GamePlayController GamePlayController { private get; set; }

		public WorldController WorldController { private get; set; }

		public UIViewController UIViewController { private get; set; }

		public CameraController CameraController { private get; set; }

		public void Initialize()
		{
		}

		private void InitializeEvents()
		{
		}

		private void GameLoadingComplete()
		{
		}

		private void LoadHomeView()
		{
		}

		public void PreLoadGame()
		{
		}

		public void LoadGame()
		{
		}

		public void PostLoadGame()
		{
		}

		public void StartGame()
		{
		}

		public void GameStepComplete()
		{
		}

		public void CompleteGame()
		{
		}

		public void FailGame()
		{
		}

		public void ReviveGame()
		{
		}

		private void GameEnd()
		{
		}

		public void UnloadGame()
		{
		}

		private void SkipGame()
		{
		}

		private void GameplaySceneLoaded()
		{
		}

		private void ShowReviveView()
		{
		}

		private void ShowLevelFailScreen()
		{
		}

		private void StopGame()
		{
		}

		private bool IsUpdatedVersion()
		{
			return false;
		}

		private void ShowUpdateDialogue()
		{
		}
	}
}
