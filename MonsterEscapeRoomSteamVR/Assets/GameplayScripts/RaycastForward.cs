using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class RaycastForward : MonoBehaviour {
    // private Valve.VR.InteractionSystem.Hand hand;
    //bool isTriggerPressed;
    GameObject currentObject = null;
    public void pullObject()
    {

        Debug.Log("You did something");
        
    }
    void Start()
    {
        //hand = gameObject.GetComponent<Valve.VR.InteractionSystem.Hand>();
    }

    // Update is called once per frame
    void Update () {
        RaycastHit hit;
        float theDistance;

        //debug raycast in the editor
        Vector3 forward = transform.TransformDirection(Vector3.forward) * 10;
        Debug.DrawRay(transform.position, forward, Color.green);
        if (Physics.Raycast(transform.position, (forward), out hit, 100f, 1 << 8))
        {

            theDistance = hit.distance;
            Debug.Log(theDistance + " meters away");
            currentObject = hit.transform.gameObject;
        }
        else
        {
            currentObject = null;
        }
        // SteamVR_Controller.Input
    }
}
