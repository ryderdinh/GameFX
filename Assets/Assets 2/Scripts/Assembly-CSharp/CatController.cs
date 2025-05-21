using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CatController : MonoBehaviour, IPointerDownHandler, IEventSystemHandler
{
	[SerializeField]
	private CatConfigs _catConfigs;

	[SerializeField]
	private Transform _catTransform;

	[SerializeField]
	private Animator _animator;

	[SerializeField]
	private EmojiController _emoji;

	[SerializeField]
	private BoxCollider _boxCollider;

	[SerializeField]
	private List<Transform> _spawnPoints;

	[SerializeField]
	private List<Transform> _chasePointsWorld1;

	[SerializeField]
	private List<Transform> _chasePointsWorld2;

	[SerializeField]
	private List<Transform> _chasePointsWorld3;

	[SerializeField]
	private List<Transform> _chasePointsWorld4;

	[SerializeField]
	private List<Transform> _chasePointsWorld5;

	private CatAnimationController _catAnimController;

	private CatState _currentState;

	private bool _isPlayerInteracted;

	private Vector3 _targetPosition;

	private int _currentShopIndex;

	private List<List<Vector3>> _positions;

	private CatStateType _currentStateType;

	public Transform CatTransform => null;

	public CatConfigs CatConfigs => null;

	public Vector3 TargetPosition => default(Vector3);

	public List<Vector3> Path => null;

	public void Initialize(int worldId)
	{
	}

	private void Update()
	{
	}

	public void ChangeState(CatState newState)
	{
	}

	public void Follow(int id)
	{
	}

	private List<Vector3> GetPositionsRange(List<Transform> transforms)
	{
		return null;
	}

	public void PlayAngryEmoji()
	{
	}

	public void PlayHeartEmoji()
	{
	}

	public void EnableCatInteraction()
	{
	}

	public void DisableCatInteraction()
	{
	}

	public void SetInteractable(bool state)
	{
	}

	public void SetCurrentStateType(CatStateType type)
	{
	}

	public void PlayCatAnimation(CatAnimationType catAnimationType)
	{
	}

	public void SetCatStateKey(int key)
	{
	}

	void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
	{
	}
}
