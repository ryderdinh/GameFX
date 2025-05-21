using UnityEngine;

[CreateAssetMenu(fileName = "GridConfigs", menuName = "Game/Grid")]
public class GridConfig : ScriptableObject
{
	[Header("Data")]
	public Vector2 GridStartingPosition;

	public Vector2 GridEndingPosition;

	public float XOffset;

	public float ZOffset;

	public int Rows;

	public int Columns;

	public float SlotHoverHeight;

	public float SlotHoverTime;

	public float SlotHighlightAlpha;

	public float SlotHighlightAlphaForBoosters;

	[Header("Tweens")]
	public float SlotFadeDuration;

	public float MovementAnimationDuration;

	public float MovementOfSameSlicesAnimationDuration;

	public float GridSnapWait;

	public float DishFullWait;

	public float DishEmptyWait;

	[Header("SlotSwap")]
	public float DragThreshold;

	[Header("Tutorial")]
	public float TotalTutorialsToShow;

	public GridPrePopulationSystem GridPrePopulationSystem;

	public int TotalSlots => 0;
}
