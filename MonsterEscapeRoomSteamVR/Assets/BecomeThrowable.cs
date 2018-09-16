using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class BecomeThrowable : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void MakeThrowable()
    {
        gameObject.AddComponent<Throwable>();

        //gameObject.GetComponent<Rigidbody>().isKinematic = false;
    }
}
