using System;
using System.Collections.Generic;
using DB;
using DG.Tweening;
using UnityEngine;

public class Dish : MonoBehaviour
{
	[SerializeField]
	private Transform _dishTransform;

	[SerializeField]
	private Transform _dishContainer;

	[SerializeField]
	private Transform _pot;

	[SerializeField]
	private Transform _container;

	[SerializeField]
	private Transform _midBud;

	[SerializeField]
	private Transform _flowerContainer;

	[SerializeField]
	private GameObject _trail;

	[SerializeField]
	private MeshFilter _midMesh;

	[SerializeField]
	private ParticleSystem _flowerRotationParticle;

	[SerializeField]
	private ParticleSystem _leavesParticles;

	[SerializeField]
	private ParticleSystem _shearParticles;

	[SerializeField]
	private ParticleSystem[] _burstParticles;

	[SerializeField]
	private List<Collider> _rotationCollider;

	[SerializeField]
	private Transform _rotator;

	[SerializeField]
	private ParticleSystem _dustParticles;

	[SerializeField]
	private ParticleSystem[] _auraLeavesParticles;

	[SerializeField]
	private MeshFilter _meshFilter;

	private FlowerRotationImpact _flowerRotationImpact;

	private List<Flower> _cakes;

	private ArrayInt _cakeData;

	private Sequence _flowerCompleteSequence;

	private Sequence _cakeRemoveSequence;

	private Sequence _wobbleSequence;

	private Sequence _flowerPotSequence;

	private Mesh _defaultMidMesh;

	private DishConfig _dishConfig;

	private StreakSystemObject _streakSystem;

	private ItemSystem _itemSystem;

	private int _rotationMultiplier;

	private bool _isReset;

	private Collider[] _boingColliders;

	private readonly HashSet<int> _cakesHashSet;

	private MaterialPropertyBlock _flowerCompletePropertyBlock;

	public ParticleSystem FlowerRotationParticle => null;

	public List<Flower> Cakes => null;

	public ArrayInt CakeData => null;

	public Transform FlowerTransform => null;

	public Transform DishTransform => null;

	public ParticleSystem ShearParticles => null;

	public void Initialize(Transform parent, ArrayInt data, List<Collider> boingColliders, int rotationOffset, Mesh dishMesh, bool animateIn = true, bool sort = true)
	{
	}

	public void ReadConfigs()
	{
	}

	public void SetSexyPot()
	{
	}

	public void UpdateCakeData(ArrayInt data)
	{
	}

	public void AddDishToSlot(Transform parent, ArrayInt slotData, int id, bool reset)
	{
	}

	public void RemoveDishFromSlot()
	{
	}

	public void ApplyWindOnDish(bool horizontal)
	{
	}

	public void AdjustDishSlotTilt(int id)
	{
	}

	public void AdjustDishSlotPosition(int id)
	{
	}

	public void UpdateDishMesh(Mesh mesh, bool animate = false)
	{
	}

	public void DowngradeDishMesh(Mesh mesh, bool animate = false)
	{
	}

	private void SetParent(Transform parent, bool reset = true)
	{
	}

	public Vector3 GetDishPosition()
	{
		return default(Vector3);
	}

	public void UpdateDishPosition(Vector3 position)
	{
	}

	public int GetFirstCakeId()
	{
		return 0;
	}

	private void AddCakesToDish(Collider[] boingColliders, bool sort = true)
	{
	}

	public void AddCake(Flower cake, bool sort = true)
	{
	}

	public Flower RemoveCake(int id, bool sort = true)
	{
		return null;
	}

	public RemovingCakeDataModel GetCakesToRemove(int id, int count)
	{
		return null;
	}

	public int ForceRemoveCakes(int id, int count)
	{
		return 0;
	}

	public void ForceRemoveCakes(int id)
	{
	}

	public void PlayDustParticles()
	{
	}

	public bool IsDishFull()
	{
		return false;
	}

	public bool IsDishEmpty()
	{
		return false;
	}

	public void DestroyDish(int comboIndex = 0)
	{
	}

	public void PlayCakeCompleteSequence()
	{
	}

	public void ResetDish()
	{
	}

	public void ResetDishOnly()
	{
	}

	public void PaintDish(int cakeID)
	{
	}

	public void UpdateFlowerTier(int cakeID)
	{
	}

	public void PlayBurstParticles(int id)
	{
	}

	public void ForceChangeCakes(int cakeID)
	{
	}

	public int ForceCompleteDish(float startDelay = 0f, float addInZ = 0f, bool completeWithDelay = true, bool isShopComplete = false, Action callback = null)
	{
		return 0;
	}

	public void CompleteDish()
	{
	}

	private int ForceRemoveCakeExceptOneCakeID(int cakeID)
	{
		return 0;
	}

	private int ForceRemoveCakeExceptOneCakeID(int cakeID, List<int> indexesOfCakesLeft, bool animate = false)
	{
		return 0;
	}

	private List<Flower> GetPetalsToRemoveList(int cakeID)
	{
		return null;
	}

	private void SpawnCakes(int cakeID)
	{
	}

	private void AfterForceCompleteDish(float addInZ = 0f, bool isShopComplete = false, Action callback = null)
	{
	}

	private void ForceCompleteDishScaleAnimation(float delay, List<int> indexesOfCakesLeft)
	{
	}

	private int GetMajorityCakeID()
	{
		return 0;
	}

	public void ActivateDish(float pos, bool moveHorizontally)
	{
	}

	public void DeactivateDish(float pos, bool moveHorizontally)
	{
	}

	public void ShowDish()
	{
	}

	public void HideDish()
	{
	}

	private void SetPotState(bool state)
	{
	}

	public void ResetDishAndCakes()
	{
	}

	private void ResetPotAndFlowers()
	{
	}

	public void ResetCakeData()
	{
	}

	public int UniqueItemsCount()
	{
		return 0;
	}

	public void SelfSort(bool force, bool sort = true)
	{
	}

	private void SortForForceCompletion(List<int> indexesOfCakesLeft)
	{
	}

	private void ResetTransform()
	{
	}

	public Sequence CakeRemoveSequence(bool randomDelayMultiplier = true)
	{
		return null;
	}

	public void CustomWobbleSequence(float duration, float strength, int vibrato)
	{
	}

	public void WrongMoveSequence()
	{
	}

	public void LevelFailSequence()
	{
	}

	public void WaterCanSequence()
	{
	}

	public void PlayRotationParticles(int cakeId)
	{
	}

	private void UpdateAuraParticlesColor(int cakeId)
	{
	}

	public void UpdateCakeIdsForLevelEnd(ArrayInt arrayInt, int id)
	{
	}

	private Sequence CakeCompleteSequence(int comboIndex = 0, float addInZ = 0f, bool isShopComplete = false, bool canUpdateMesh = true)
	{
		return null;
	}

	public Sequence VanishDishSequence()
	{
		return null;
	}

	public void CakeScaleUpSequenceWithDelay()
	{
	}

	private void CakeScaleUpSequence()
	{
	}

	private void CakeScaleUpSequenceSexyPot()
	{
	}

	private void SpawnFlowerCompleteParticle()
	{
	}

	public void UpdateMidMesh()
	{
	}

	public void UpdateFlowersMaterialOnComplete()
	{
	}

	private void UpdateFlowerPetalsMaterial(List<Flower> cakes)
	{
	}

	public void SetDishState(bool state)
	{
	}

	public Vector3 MoveDish(Vector3 targetPosition)
	{
		return default(Vector3);
	}

	public void ResetDishPosition()
	{
	}

	public void SetCakeData(int[] cakeData)
	{
	}

	public Sequence MoveDishFreely(Vector3 targetPoint, Vector3 startPoint, bool rightDirection = false)
	{
		return null;
	}

	public int CakeIDCount(int cakeID)
	{
		return 0;
	}
}
