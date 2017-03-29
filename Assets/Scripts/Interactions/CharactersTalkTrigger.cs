using UnityEngine;
using System.Collections;
using GvrUtilities;
using UnityEngine.EventSystems;

namespace Interactions {
    public class CharactersTalkTrigger : GazeHoverBehaviour {

		[SerializeField] private GameObject m_chest;

        private Animator m_anim;
        private int m_talkStateHash = Animator.StringToHash("TalkTrigger");

        private bool m_executed = false;

        void Start() {
            m_anim = GetComponent<Animator>();
        }

        public override void Execute() {
            if (!m_executed) {
                m_anim.SetTrigger(m_talkStateHash);
                m_executed = true;
            }
        }

        protected override void OnHover() {
        }

        protected override void OnHoverExit() {
        }

		void ActiveChest() {
			Debug.Log ("Active Chest");
			ExecuteEvents.Execute<Chest>(m_chest, null, (x, y) => x.ActiveChest());
		}
    }
}