using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseAudioScript : MonoBehaviour {

	[SerializeField] private AudioClip[] m_clips;

	private GvrAudioSource m_audioSource;

	private int m_arrSize;
	private int m_nextClip = 0;

	void Start() {
		m_audioSource = GetComponent<GvrAudioSource>();

		m_arrSize = m_clips.Length;
	}

	void nextClip() {
		Debug.Log (m_nextClip);
		if (m_arrSize > 0 && m_nextClip < m_arrSize) {
			m_audioSource.clip = m_clips [m_nextClip];
			m_audioSource.Play();

			m_nextClip++;
		}	
	}
}
