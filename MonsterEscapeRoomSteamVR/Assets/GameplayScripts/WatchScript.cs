using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WatchScript : MonoBehaviour {

	// Use this for initialization
	void Awake () {
        GameManager.Self.Watch = this;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
