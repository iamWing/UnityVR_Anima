using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using ButtonInteractions;

public class StartJourney : StartQuitUIEffect {

	public override void Execute() {
		SceneManager.LoadScene(1);
	}

}
