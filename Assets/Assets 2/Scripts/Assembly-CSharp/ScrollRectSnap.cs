using System;
using UnityEngine;

public class ScrollRectSnap
{
	private enum DraggedDirection
	{
		Up = 0,
		Down = 1,
		Right = 2,
		Left = 3
	}

	private RectTransform _panel;

	private RectTransform[] _rects;

	private RectTransform _center;

	private Action<int> _snapCallback;

	private float[] _rectsdistance;

	private float[] _distReposition;

	private bool _dragging;

	private bool _targetNearestButton;

	private bool _isInitialized;

	private bool _isIndexUpdate;

	private bool _canScroll;

	private float _reorderDistance;

	private float _lerpSpeed;

	private int _startRectIndex;

	private int _rectDistance;

	private int _minRectNum;

	private float _defaultLerpSpeed;

	private float _scrollSensitivity;

	private float _tapTime;

	private float _timeSensitivity;

	private float _deltaTime;

	private Vector3 _swipeStartPosition;

	private DraggedDirection _swipeDirection;

	public RectTransform CurrentItem { get; private set; }

	public ScrollRectSnap(Action<int> callback, RectTransform panel, RectTransform[] rects, RectTransform center, Transform objTransform, int startRectIndex, float lerpSpeed = 5f, float time = 0.35f, float scrollSensitivity = 0.2f)
	{
	}

	public void Initialize()
	{
	}

	public void SnapScroll()
	{
	}

	private void LerpToRect(float position)
	{
	}

	public void GoToRect(int index)
	{
	}

	public void StartDrag()
	{
	}

	public void EndDrag()
	{
	}

	private DraggedDirection GetDragDirection(Vector3 dragVector)
	{
		return default(DraggedDirection);
	}
}
