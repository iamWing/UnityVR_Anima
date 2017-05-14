using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoneAnimMeetDragonTrigger : MonoBehaviour {

	[SerializeField] private GameObject m_characters;

	private Animator m_anim;
	private int m_meetDragonStateHash = Animator.StringToHash("MeetDragon");

	// Use this for initialization
	void Start () {
		m_anim = m_characters.GetComponent<Animator> ();	
	}

	private void TriggerAnimation() {
		Debug.Log ("Meet dragon");
		m_anim.SetTrigger (m_meetDragonStateHash);
	}
	
}
