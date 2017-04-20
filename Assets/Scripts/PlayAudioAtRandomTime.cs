using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudioAtRandomTime : MonoBehaviour {

    GvrAudioSource audioSource;
	// Use this for initialization
	void Start () {
        audioSource = GetComponent<GvrAudioSource>();
        Invoke("PlayAudio", Random.value * 5);
	}

    void PlayAudio()
    {
        audioSource.Play();
        Invoke("PlayAudio", Random.value * 5 + 3);
    }
}
