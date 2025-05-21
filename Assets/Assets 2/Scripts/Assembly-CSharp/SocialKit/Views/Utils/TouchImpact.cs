using UnityEngine;
using UnityEngine.EventSystems;

namespace SocialKit.Views.Utils
{
	public class TouchImpact : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		[SerializeField]
		private RectTransform _container;

		[SerializeField]
		private float _downScaleOffset;

		[SerializeField]
		private float _duration;

		private Vector3 _scale;

		private void Awake()
		{
		}

		public void OnPointerDown(PointerEventData eventData)
		{
		}

		public void OnPointerUp(PointerEventData eventData)
		{
		}
	}
}
