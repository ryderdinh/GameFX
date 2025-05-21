using UnityEngine;

namespace AmazingAssets.CurvedWorld
{
	[ExecuteAlways]
	public class CurvedWorldController : MonoBehaviour
	{
		public enum AXIS_TYPE
		{
			Transform = 0,
			Custom = 1,
			CustomNormalized = 2
		}

		public BEND_TYPE bendType;

		[Range(1f, 32f)]
		public int bendID;

		public Transform bendPivotPoint;

		public Vector3 bendPivotPointPosition;

		public Transform bendRotationCenter;

		public Vector3 bendRotationCenterPosition;

		public Vector3 bendRotationAxis;

		public AXIS_TYPE bendRotationAxisType;

		public Transform bendRotationCenter2;

		public Vector3 bendRotationCenter2Position;

		public float bendVerticalSize;

		public float bendVerticalOffset;

		public float bendHorizontalSize;

		public float bendHorizontalOffset;

		public float bendCurvatureSize;

		public float bendCurvatureOffset;

		public float bendAngle;

		public float bendAngle2;

		public float bendMinimumRadius;

		public float bendMinimumRadius2;

		public float bendRolloff;

		public bool disableInEditor;

		public bool manualUpdate;

		private BEND_TYPE previousBentType;

		private int previousID;

		private int materialPropertyID_PivotPoint;

		private int materialPropertyID_RotationCenter;

		private int materialPropertyID_RotationCenter2;

		private int materialPropertyID_RotationAxis;

		private int materialPropertyID_BendSize;

		private int materialPropertyID_BendOffset;

		private int materialPropertyID_BendAngle;

		private int materialPropertyID_BendMinimumRadius;

		private int materialPropertyID_BendRolloff;

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnEnable()
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

		private void UpdateShaderdata()
		{
		}

		private void UpdateShaderDataDisabled()
		{
		}

		public void DisableBend()
		{
		}

		public void EnableBend()
		{
		}

		public void ManualUpdate()
		{
		}

		private void CheckBendChanging()
		{
		}

		private void GenerateShaderPropertyIDs()
		{
		}

		public Vector3 TransformPosition(Vector3 vertex)
		{
			return default(Vector3);
		}

		public Quaternion TransformRotation(Vector3 vertex, Vector3 forwardVector, Vector3 rightVector)
		{
			return default(Quaternion);
		}

		public void SetBendVerticalSize(float value)
		{
		}

		public void SetBendVerticalOffset(float value)
		{
		}

		public void SetBendHorizontalSize(float value)
		{
		}

		public void SetBendHorizontalOffset(float value)
		{
		}

		public void SetBendCurvatureSize(float value)
		{
		}

		public void SetBendCurvatureOffset(float value)
		{
		}

		public void SetBendAngle(float value)
		{
		}

		public void SetBendAngle2(float value)
		{
		}

		public void SetBendMinimumRadius(float value)
		{
		}

		public void SetBendMinimumRadius2(float value)
		{
		}

		public void SetBendRolloff(float value)
		{
		}
	}
}
