using UnityEngine;
using System.Collections;
using ProjectUtilities;

namespace ButtonInteractions {
    public class CharactersTalkTrigger : GazeHoverBehaviour {

        private Animator m_anim;
        private int m_talkStateHash = Animator.StringToHash("CharactersTalking");

        void Start() {
            m_anim = GetComponentInParent<Animator>();
        }

        public override void Execute() {
            m_anim.SetTrigger(m_talkStateHash);
        }

        protected override void OnHover() {
            throw new System.NotImplementedException();
        }

        protected override void OnHoverExit() {
            throw new System.NotImplementedException();
        }
    }
}