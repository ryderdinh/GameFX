using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DB;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Mindstorm.GamePeformance
{
	public class PerformanceOptimization : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CStart_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public PerformanceOptimization _003C_003E4__this;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CStart_003Ed__18(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CCalculate_averageFPS_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public PerformanceOptimization _003C_003E4__this;

			private int _003CfpsCountDuration_003E5__2;

			private float _003CaverageFPS_003E5__3;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CCalculate_averageFPS_003Ed__27(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		public PostProcessData PostProcessData;

		public UniversalRendererData UniversalRendererData;

		public DevicePerformaceType DefaultIOSDevicePerformaceType;

		public DevicePerformaceType DefaultAndroidDevicePerformaceType;

		public int FpsCountForTestDuration;

		public Text PerformancePoints;

		public Text PerformanceType;

		public DBInt DeviceType;

		private static int _fpsPoints;

		private PlatformType _platformType;

		private static int _performancePoints;

		public static bool IsPostProcessingEnabled;

		public static UniversalRenderPipelineAsset UniversalRenderPipelineAsset;

		public UniversalRenderPipelineAsset CurrentSettings { get; private set; }

		private void Awake()
		{
		}

		[IteratorStateMachine(typeof(_003CStart_003Ed__18))]
		private IEnumerator Start()
		{
			return null;
		}

		private void InitializeSettings()
		{
		}

		private void SetConfigurations(DevicePerformaceType performaceType)
		{
		}

		private void ApplyPerformaceSettings()
		{
		}

		private void OnLevelFinishedLoading(Scene scene, LoadSceneMode mode)
		{
		}

		public DevicePerformaceType FindDevicePerformaceType()
		{
			return default(DevicePerformaceType);
		}

		private void SetPlatformType()
		{
		}

		private static DevicePerformaceType FindIosDevicePerformaceType()
		{
			return default(DevicePerformaceType);
		}

		private static DevicePerformaceType FindAndroidDevicePerformaceType()
		{
			return default(DevicePerformaceType);
		}

		[IteratorStateMachine(typeof(_003CCalculate_averageFPS_003Ed__27))]
		private IEnumerator Calculate_averageFPS()
		{
			return null;
		}

		public void StartObservingFPSForPerformanceMetric()
		{
		}
	}
}
