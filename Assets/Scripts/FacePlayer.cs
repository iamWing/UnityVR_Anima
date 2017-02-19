using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FacePlayer : MonoBehaviour {

	// Use this for initialization
	void Start () {
        transform.LookAt(GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>());
	}
	

}
