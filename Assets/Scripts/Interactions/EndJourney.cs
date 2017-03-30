using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Interactions;

public class EndJourney : StartQuitUIEffect {

	public override void Execute() {
		Application.Quit ();
	}

}
