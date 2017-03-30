using UnityEngine;
using UnityEngine.UI;
using GvrUtilities;
using UnityEngine.EventSystems;

namespace Interactions {
	public class Chest : GazeHoverBehaviour {

		[SerializeField] private GameObject m_chest;
		[SerializeField] private Sprite m_chestOpened;
		[SerializeField] private GameObject m_particle;
		[SerializeField] private float m_particleLifeTime = 5.0f;

		[SerializeField] private GameObject m_dragon;

		private Image m_chestImage;

		private bool m_executed = false;

		// Use this for initialization
		void Start() {
			m_chestImage = m_chest.GetComponent<Image> ();
			m_chestImage.raycastTarget = false;
		}

		public override void Execute() {
			if (!m_executed) {
				m_chestImage.sprite = m_chestOpened;
				Invoke ("DisableParticle", 3.0f);
				CancelInvoke ("EnableEffect");

				m_chestImage.raycastTarget = false;

				ExecuteEvents.Execute<DragonAnimTrigger> (m_dragon, null, (x, y) => x.ShowUp ());

				m_executed = true;
			}
		}

		protected override void OnHover() {
		}

		protected override void OnHoverExit() {
		}

		public void ActiveChest() {
			Debug.Log ("Received");
			m_chestImage.raycastTarget = true;
			InvokeRepeating ("EnableEffect", 0, 5.0f);
		}

		void EnableEffect() {
			m_particle.SetActive (true);
			Invoke ("DisableParticle", m_particleLifeTime);
		}

		void DisableParticle() {
			m_particle.SetActive (false);
		}

	}
}