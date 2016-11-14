﻿using UnityEngine;
using System.Collections;

public class ConditionLever1 : MonoBehaviour {

	[SerializeField] GameObject attachedObj;

	void Update () {
		Debug.Log (this.gameObject.GetComponent<InteractiveBehaviour> ().currentState);

		if (this.gameObject.GetComponent<InteractiveBehaviour> ().currentState != -1) {
			if(attachedObj.GetComponent<ElevatorBehaviour>().up)
				this.gameObject.GetComponent<InteractiveBehaviour> ().currentState = 0;
			else if (attachedObj.GetComponent<ElevatorBehaviour> ().isReady)
				this.gameObject.GetComponent<InteractiveBehaviour> ().currentState = 0;
		}
	}

	public void UseObj() {
		attachedObj.GetComponent<ElevatorBehaviour> ().Use ();
		this.gameObject.GetComponent<InteractiveBehaviour> ().currentState = -1;
		LevelStructure.Instance.NextStep();
		StatePuppetBehavior.Instance.currentState.ToFollowingState ();
	}
}
