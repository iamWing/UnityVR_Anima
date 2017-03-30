using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationScript : MonoBehaviour {

    [SerializeField]
    private float degreesPerSecond = 5f;

    private Transform tf;
    private Vector3 currentRotation;
    
	// Use this for initialization
	void Start () {
        tf = GetComponent<Transform>();
        currentRotation = tf.rotation.eulerAngles;
	}   
	
	// Update is called once per frame
	void FixedUpdate () {
        currentRotation.y -= degreesPerSecond * Time.deltaTime;
        tf.rotation = Quaternion.Euler(currentRotation);
	}
}
