using System.Collections.Generic;
using UnityEngine;

namespace AmazingAssets.CurvedWorld
{
	[ExecuteInEditMode]
	public class CurvedWorldBoundingBox : MonoBehaviour
	{
		public float scale;

		private float currentScale;

		private Vector3 boundingBoxSize;

		private Bounds originalBounds;

		private SkinnedMeshRenderer skinnedMeshRenderer;

		private MeshFilter meshFilter;

		private static Dictionary<int, Bounds> boundsDictionary;

		public bool visualizeInEditor;

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

		private void OnDrawGizmos()
		{
		}

		private void Reset()
		{
		}

		public void RecalculateBounds()
		{
		}
	}
}
