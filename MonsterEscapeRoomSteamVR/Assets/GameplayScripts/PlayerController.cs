using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	// Use this for initialization
	void Awake () {
        GameManager.Self.PC = this;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
