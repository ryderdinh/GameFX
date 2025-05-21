using UnityEngine;

namespace RainbowMagic
{
	public class RainbowFireProjectile : MonoBehaviour
	{
		private RaycastHit hit;

		public GameObject[] projectiles;

		public Transform spawnPosition;

		[HideInInspector]
		public int currentProjectile;

		public float speed;

		private RainbowButtonScript selectedProjectileButton;

		private void Start()
		{
		}

		private void Update()
		{
		}

		public void nextEffect()
		{
		}

		public void previousEffect()
		{
		}

		public void AdjustSpeed(float newSpeed)
		{
		}
	}
}
