using UnityEngine;
using UnityEngine.UI;

namespace RainbowMagic
{
	public class RainbowButtonScript : MonoBehaviour
	{
		public GameObject Button;

		private Text MyButtonText;

		private string projectileParticleName;

		private RainbowFireProjectile effectScript;

		private RainbowProjectileScript projectileScript;

		public float buttonsX;

		public float buttonsY;

		public float buttonsSizeX;

		public float buttonsSizeY;

		public float buttonsDistance;

		private void Start()
		{
		}

		private void Update()
		{
		}

		public void getProjectileNames()
		{
		}

		public bool overButton()
		{
			return false;
		}
	}
}
