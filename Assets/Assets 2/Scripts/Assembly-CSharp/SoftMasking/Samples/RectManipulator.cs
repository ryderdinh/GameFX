using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace SoftMasking.Samples
{
	[RequireComponent(typeof(RectTransform))]
	public class RectManipulator : UIBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
	{
		[Flags]
		public enum ManipulationType
		{
			None = 0,
			Move = 1,
			ResizeLeft = 2,
			ResizeUp = 4,
			ResizeRight = 8,
			ResizeDown = 0x10,
			ResizeUpLeft = 6,
			ResizeUpRight = 0xC,
			ResizeDownLeft = 0x12,
			ResizeDownRight = 0x18,
			Rotate = 0x20
		}

		public RectTransform targetTransform;

		public ManipulationType manipulation;

		public ShowOnHover showOnHover;

		[Header("Limits")]
		public Vector2 minSize;

		[Header("Display")]
		public Graphic icon;

		public float normalAlpha;

		public float selectedAlpha;

		public float transitionDuration;

		private bool _isManipulatedNow;

		private Vector2 _startAnchoredPosition;

		private Vector2 _startSizeDelta;

		private float _startRotation;

		private RectTransform parentTransform => null;

		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		public void OnPointerExit(PointerEventData eventData)
		{
		}

		private void HighlightIcon(bool highlight, bool instant = false)
		{
		}

		protected override void Start()
		{
		}

		public void OnBeginDrag(PointerEventData eventData)
		{
		}

		private void RememberStartTransform()
		{
		}

		public void OnDrag(PointerEventData eventData)
		{
		}

		private Vector2 ToParentSpace(Vector2 position, Camera eventCamera)
		{
			return default(Vector2);
		}

		private void DoMove(Vector2 parentSpaceMovement)
		{
		}

		private bool Is(ManipulationType expected)
		{
			return false;
		}

		private void MoveTo(Vector2 desiredAnchoredPosition)
		{
		}

		private Vector2 ClampPosition(Vector2 position)
		{
			return default(Vector2);
		}

		private void DoRotate(Vector2 startParentPoint, Vector2 targetParentPoint)
		{
		}

		private float DeltaRotation(Vector2 startLever, Vector2 endLever)
		{
			return 0f;
		}

		private void DoResize(Vector2 parentSpaceMovement)
		{
		}

		private Vector2 ProjectResizeOffset(Vector2 localOffset)
		{
			return default(Vector2);
		}

		private Vector2 ResizeSign()
		{
			return default(Vector2);
		}

		private void SetSizeDirected(Vector2 localOffset, Vector2 sizeSign)
		{
		}

		private Vector2 ClampSize(Vector2 size)
		{
			return default(Vector2);
		}

		public void OnEndDrag(PointerEventData eventData)
		{
		}
	}
}
