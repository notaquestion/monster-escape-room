using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NarrativeEventManager : MonoBehaviour {

	// Use this for initialization
	void Awake () {
        GameManager.Self.NarrativeManager = this;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
