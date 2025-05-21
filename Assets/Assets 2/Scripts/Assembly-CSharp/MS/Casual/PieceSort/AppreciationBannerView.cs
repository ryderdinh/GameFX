using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace MS.Casual.PieceSort
{
	public abstract class AppreciationBannerView : MonoBehaviour
	{
		[SerializeField]
		private GameObject _container;

		[SerializeField]
		private Transform _textTransform;

		[SerializeField]
		private GameObject _singleNumberContainer;

		[SerializeField]
		private GameObject _doubleNumberContainer;

		[SerializeField]
		private Transform _numberTransformSingle;

		[SerializeField]
		private Transform _numberTransformDouble;

		[SerializeField]
		private Transform _numberTransformDouble2;

		[SerializeField]
		protected Image _numberValueImageSingle;

		[SerializeField]
		protected Image _numberValueImageDouble;

		[SerializeField]
		protected Image _numberValueImageDouble2;

		[SerializeField]
		private ParticleSystem _mergeParticles;

		[SerializeField]
		private ParticleSystem _mergeParticles2;

		private Sequence _sequence;

		private float _numberSize;

		protected bool _IsAnimationPlaying;

		protected AppreciationBannerConfig _Configs;

		protected abstract void RegisterEvents();

		protected abstract void UnRegisterEvents();

		public virtual void Initialize()
		{
		}

		public void Show()
		{
		}

		public void Hide()
		{
		}

		public virtual void PlayAppreciationAnimation(CollectablesData data)
		{
		}

		private void PlayAnimation()
		{
		}

		private void ReplayAnimation(int id)
		{
		}

		private void ResetTexts()
		{
		}

		private void AnimationCompleted()
		{
		}

		protected virtual void UpdateNumbers(int id)
		{
		}

		protected virtual void UpdateNumbersSprites(int id, Sprite[] sprites)
		{
		}
	}
}
