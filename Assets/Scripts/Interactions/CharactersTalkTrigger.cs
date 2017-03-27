using UnityEngine;
using System.Collections;
using GvrUtilities;

namespace Interactions {
    public class CharactersTalkTrigger : GazeHoverBehaviour {

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
            m_executed = false; // TODO remove for actual implementation
        }
    }
}