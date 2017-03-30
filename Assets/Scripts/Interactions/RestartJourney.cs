using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using Interactions;

public class RestartJourney : StartQuitUIEffect {

	public override void Execute() {
		SceneManager.LoadScene (0);
	}
}
