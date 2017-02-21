using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnPointerHover : MonoBehaviour {

    private float hoverTime = 3.0f;
    [SerializeField] private Image progressBar;

	// Use this for initialization
	void Start () {
        progressBar.fillAmount = 0;
	}

	// Update is called once per frame
	void Update () {

        if (progressBar.fillAmount < 1) {
            progressBar.fillAmount += 1.0f / hoverTime * Time.deltaTime;
        }
	}
}
