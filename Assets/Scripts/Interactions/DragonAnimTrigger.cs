using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Interactions {
	public class DragonAnimTrigger : MonoBehaviour, IEventSystemHandler {

		[SerializeField] private GameObject m_dragon;
		[SerializeField] private GameObject m_characters;

		private Animator m_anim;
		private int m_showUpStateHash = Animator.StringToHash ("ShowUpTrigger");
		private int m_talkStateHash = Animator.StringToHash ("TalkTrigger");

		// Use this for initialization
		void Start() {
			m_anim = GetComponent<Animator> ();
		}

		public void ShowUp() {
			m_dragon.SetActive (true);
			m_anim.SetTrigger (m_showUpStateHash);
		}

		void Talk() {
			m_anim.SetTrigger (m_talkStateHash);
		}

		void NextCharacterScripts() {
			ExecuteEvents.Execute<BaseAudioScript> (m_characters, null, (x, y) => x.nextClip ());		
		}
	
	}
}