using UnityEngine;

namespace AmazingAssets.CurvedWorld
{
	[ExecuteAlways]
	[RequireComponent(typeof(Camera))]
	public class CurvedWorldCamera : MonoBehaviour
	{
		public enum MATRIX_TYPE
		{
			Perspective = 0,
			Orthographic = 1
		}

		public MATRIX_TYPE matrixType;

		[Range(1f, 179f)]
		public float fieldOfView;

		public float size;

		public bool nearClipPlaneSameAsCamera;

		public float nearClipPlane;

		private Camera activeCamera;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void Reset()
		{
		}
	}
}
