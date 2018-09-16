using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BecomeThrowable : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void MakeThrowable()
    {
        gameObject.AddComponent<Valve.VR.InteractionSystem.Throwable>();
    }
}
