using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ButtonInteractions;

public class EndJourney : StartQuitUIEffect {

	public override void Execute() {
		Application.Quit ();
	}

}
