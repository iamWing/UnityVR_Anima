using UnityEngine;
using System.Collections;
using ProjectUtilities;

namespace ButtonInteractions {
    public class CharactersTalkTrigger : GazeHoverBehaviour {

        private Animator m_anim;
        private int m_talkStateHash = Animator.StringToHash("CharactersTalking");

        private bool m_executed = false;

        void Start() {
            m_anim = GetComponentInParent<Animator>();
        }

        public override void Execute() {
            if (!m_executed) {
                m_anim.SetTrigger(m_talkStateHash);
                m_executed = true;
            }
        }

        protected override void OnHover() {
            throw new System.NotImplementedException();
        }

        protected override void OnHoverExit() {
            throw new System.NotImplementedException();
        }
    }
}