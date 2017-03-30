using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndofJourney : MonoBehaviour {

	[SerializeField] private GameObject m_restartBtn;

	void ActiveRestartButton() {
		m_restartBtn.SetActive (true);
	}

}
