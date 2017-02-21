using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Utilities;

public class GvrPointerHoverEvent : MonoBehaviour, IGvrPointerHoverEvent {

    [SerializeField] private GameObject m_progressBar;
    [SerializeField] private Image m_progress;

    private float m_hoverTime = 2.0f; // hover 2s to preform as click
    private bool m_onHover = false;

    private IGvrPointerHoverTarget m_target;

	// Use this for initialization
	void Start () {
        m_progress.fillAmount = 0;
	}

	// Update is called once per frame
	void Update () {
        if (m_onHover) {
            ActiveProgressBar();
        }
	}

    void IGvrPointerHoverEvent.OnGvrPointerHover(IGvrPointerHoverTarget target) {
        m_target = target;
        m_onHover = true;

        Debug.Log("Msg receive");
    }

    void ActiveProgressBar() {
        m_progressBar.SetActive(true);

        if (m_progress.fillAmount < 1) {
            m_progress.fillAmount += 1.0f / m_hoverTime * Time.deltaTime;
        } else {
            m_target.Execute();
        }
    }
}
