using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class Telekenisis : MonoBehaviour {
    public Transform target;



    public float PullForce = 100;

    private SteamVR_Controller.Device LeftController
    {
        get
        {
            return GameObject.Find("Hand1").GetComponent<Valve.VR.InteractionSystem.Hand>().controller;
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(target != null)
            AttractObject(target.gameObject, 1);

        if (LeftController.GetHairTriggerUp())
        {
            shootTarget();
            ForgetTarget();
        }
            
	}

    void AttractObject(GameObject target, float percent)
    {
        Vector3 VecToThis = transform.position - target.transform.position;

        if(VecToThis.magnitude > 1)
        {
            VecToThis.Normalize();
        }
        //else
        {
            target.GetComponent<Rigidbody>().velocity *= 0.25f;
        }




        target.GetComponent<Rigidbody>().AddForce(VecToThis * PullForce * percent);
    }

    public void AssignTarget(GameObject target_)
    {
        target = target_.transform;
    }

    public void shootTarget()
    {


        target.rotation = LeftController.transform.rot;
        

        


        target.GetComponent<Rigidbody>().velocity = target.transform.forward*-15;
    }

    public void ForgetTarget()
    {
        target = null;
    }

}
