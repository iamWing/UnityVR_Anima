using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GvrUtilities;
using UnityEngine.EventSystems;

namespace Interactions {
	public class BoneAnimTalkTrigger : GazeHoverBehaviour {

		[SerializeField] private GameObject m_chest;

		private Animator m_anim;
		private int m_walkStateHase = Animator.StringToHash ("Move2Chest");

		private bool m_executed = false;

		// Use this for initialization
		void Start () {
			m_anim = GetComponent<Animator> ();
		}

		public override void Execute() {
			if (!m_executed) {
				m_anim.SetTrigger (m_walkStateHase);

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